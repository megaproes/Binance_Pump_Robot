using Binance.Net.Objects.Spot;
using CryptoExchange.Net.Authentication;
using Binance.Net;
using Binance.Net.Objects.Spot.MarketData;
using Binance.Net.SymbolOrderBooks;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using Binance.Net.Enums;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CryptoExchange.Net.Objects;
using System.Threading;
using System.Diagnostics;
using Binance.Net.Objects.Shared;
using TeleSharp.TL;
using TeleSharp.TL.Channels;
using TeleSharp.TL.Messages;
using TLSharp;
using TLSharp.Core;
using Binance.Net.Objects.Spot.SpotData;

namespace BinancePumpRobot
{
    using static Math;
    public partial class MainForm : Form
    {
        #region Default client login options
        BinanceClientOptions binanceDefault;
        BinanceClient client;

        BinanceSocketClient SocketClient;
        WebCallResult<string> startResult;
        WebCallResult<BinanceOrderOcoList> result2;
        string key = Properties.Settings.Default.apiKey;
        string secret = Properties.Settings.Default.apiSecret;

        string coin = "";
        string stringWithCoin = "";
        decimal pricePumpTicket;
        decimal quantityToEntry;
        WebCallResult<BinancePrice> btcPrice;
        WebCallResult<BinancePrice> pricePT;
        Stopwatch stopwatch = new Stopwatch();

        TelegramClient telegram_Client;
        TLDialogs dialogs;
        TLChannel chat;
        TLAbsInputPeer inputPeer;
        TLChannelMessages history;
        TLMessage mes;
        int apiId = 0;
        string apiHash = "";
        string user_number = "";
        string hash = "";
        #endregion

        public MainForm()
        {

            InitializeComponent();

            #region Настройка соединения
            apiId = Properties.Settings.Default.apiID_Telegram;
            apiHash = Properties.Settings.Default.apiHash_Telegram;
            user_number = Properties.Settings.Default.number_Telegram;

            if (apiId == 0 || apiHash == string.Empty || user_number == string.Empty)
            {

                Thread.Sleep(1000);
                ConnectionToTelegram connectionToTelegram = new ConnectionToTelegram();
                connectionToTelegram.ShowDialog();
            }
            else
            {
                telegram_Client = new TelegramClient(apiId, apiHash, null, "sessionSUKA");
                telegram_Client.ConnectAsync();
            }

            key = Properties.Settings.Default.apiKey;
            secret = Properties.Settings.Default.apiSecret;
            if (key == string.Empty || secret == string.Empty)
            {

                Thread.Sleep(1000);
                ConnectionToBinance connectionToBinance = new ConnectionToBinance();
                connectionToBinance.ShowDialog();

                binanceDefault = new BinanceClientOptions();
                SocketClient = new BinanceSocketClient();

                key = Properties.Settings.Default.apiKey;
                secret = Properties.Settings.Default.apiSecret;
                binanceDefault.LogVerbosity = CryptoExchange.Net.Logging.LogVerbosity.Debug;
                binanceDefault.ApiCredentials = new ApiCredentials(key, secret);
                client = new BinanceClient(binanceDefault);

                startResult = client.Spot.UserStream.StartUserStream();

                SocketClient = new BinanceSocketClient();
                SocketClient.SetApiCredentials(key, secret);

            }
            else
            {
                binanceDefault = new BinanceClientOptions();
                binanceDefault.LogVerbosity = CryptoExchange.Net.Logging.LogVerbosity.Debug;
                binanceDefault.ApiCredentials = new ApiCredentials(key, secret);
                client = new BinanceClient(binanceDefault);

                SocketClient = new BinanceSocketClient();
                SocketClient.SetApiCredentials(key, secret);
            }
            #endregion
        }

        #region Binance Logic
        private async void UpdatePriceAsync()
        {
            /* var price = await client.Spot.Market.GetPriceAsync("BTCUSDT");
             this.BTCUSDT_Price_TB.Text = price.Data.Price.ToString();*/

            Task task1 = new Task(new Action(() =>
            {
                SocketClient.Spot.SubscribeToOrderBookUpdates("BTCUSDT", 100, btcUpdate =>
                {
                    btcPrice = client.Spot.Market.GetPriceAsync("BTCUSDT").Result;
                    BTCUSDT_Price_TB.Text = btcPrice.Data.Price.ToString();
                });
            }));


            task1.Start();
            await task1;
        }

        /// <summary>
        /// If user has inputted text with a coin, method reads and buys it; otherwise, it does nothing.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void coinToPumpTB_TextChanged(object sender, EventArgs e)
        {
            if (ReadCoinToPump() == false) return;
            BuyCoin();
        }

        /// <summary>
        /// Buys a coin with specific parameters, which user had selected before buying
        /// </summary>
        private async void BuyCoin()
        {
            #region Variables
            //decimal pricePumpTicket;

            decimal procentToEarn = 0;
            string ticketForOrder = this.pumpingCoin_TB.Text;
            decimal userAssetToPump = 0;
            decimal stopLoss = 0;
            #endregion

            #region Parsing from textBoxes to variables
            var res1 = decimal.TryParse(this.assetToPump_TB.Text, out userAssetToPump);
            var res2 = decimal.TryParse(this.procentToEarn_TB.Text, out procentToEarn);
            var res3 = decimal.TryParse(this.stopLoss_TB.Text, out stopLoss);
            if ((res1 || res2 || res3) == false)
            {
                MessageBox.Show("'Asset', 'TP' or 'SL' are null or not in correct format, hence it will not buy.\n" +
                    "Try to use a coma (','), instead a dot ('.'); and be sure that you've chosen an appropriate currency, " +
                    "before putting it in.",
                    "Faulted buy", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            #endregion

            #region Logic of buying and placing orders
            try
            {
                //var btcprice = await client.Spot.Market.GetPriceAsync("BTCUSDT");
                pricePT = await client.Spot.Market.GetPriceAsync(ticketForOrder);

                pricePumpTicket = pricePT.Data.Price;

                #region The amount that's using in the pump can be expressed in BTC or USDT
                if (currencyToPut_CB.Items[currencyToPut_CB.SelectedIndex].ToString() == "BTC")
                {
                    quantityToEntry = Round(userAssetToPump / (pricePumpTicket));
                }
                else
                {
                    quantityToEntry = Round(userAssetToPump / (pricePumpTicket * btcPrice.Data.Price));
                }
                #endregion

                // Лимитная цена, по которой будет выставлен TP
                decimal priceToClose = Round(pricePumpTicket + pricePumpTicket * procentToEarn,
                    pricePumpTicket.ToString().Length - 2);

                if (quantityToEntry == 0)
                {
                    MessageBox.Show("Quantity to go is null");
                    return;
                }

                if (quantityToEntry >= 1)
                {
                    #region Market buy and limit order logic
                    // Покупаем монету по рынку.
                    var result1 = await client.Spot.Order.PlaceOrderAsync(ticketForOrder, OrderSide.Buy, OrderType.Market,
                        quantityToEntry, null, null, null);
                

                    if (!result1.Success)
                    {
                        MessageBox.Show(result1.Error.Message);
                        return;
                    }

                    // Выставляем лимитный ордер (на 1 од. меньше) на продажу на n% выше покупки, которые указал пользователь
                    /*  var result2 = await client.Spot.Order.PlaceOrderAsync(
                                ticketForOrder, OrderSide.Sell, OrderType.Limit, quantityToEntry - 1,
                                null, null, priceToClose, TimeInForce.GoodTillCancel);*/

                    decimal fillPrice = result1.Data.AverageFillPrice.Value;

                    decimal stopPrice = Round(fillPrice - fillPrice * stopLoss,
                      pricePumpTicket.ToString().Length - 2);

                    decimal stopLimitPrice = Round(fillPrice - fillPrice * (stopLoss + 0.025m),
                     pricePumpTicket.ToString().Length - 2);

                    result2 = await client.Spot.Order.PlaceOcoOrderAsync(
                              ticketForOrder, OrderSide.Sell, quantityToEntry - 1, priceToClose, stopPrice,
                              stopLimitPrice, null, null, null, null, null, TimeInForce.GoodTillCancel);



                    #region TESTING SOME NEW FUCTIONS
                    /*if (limitsQuantity_CB.Items[limitsQuantity_CB.SelectedIndex].ToString() == "2 limits")
                    {
                        decimal firstLimitProcentToEarn = decimal.Parse(firstLimit_TB.Text);
                        decimal secondLimitProcentToEarn = decimal.Parse(secondLimit_TB.Text);

                        decimal firstLimitPrice = Round(pricePumpTicket + pricePumpTicket * firstLimitProcentToEarn,
                pricePumpTicket.ToString().Length - 2);
                        decimal secondLimitPrice = Round(pricePumpTicket + pricePumpTicket * secondLimitProcentToEarn,
                pricePumpTicket.ToString().Length - 2);

                        decimal quantityForTwoOrders = Round((quantityToEntry - 1) / 2, pricePumpTicket.ToString().Length - 2);
                        result2 = await client.Spot.Order.PlaceOcoOrderAsync(
                            ticketForOrder, OrderSide.Sell, quantityForTwoOrders, firstLimitPrice, stopPrice, stopLimitPrice,
                            null, null, null, null, null, TimeInForce.GoodTillCancel);

                        result2 = await client.Spot.Order.PlaceOcoOrderAsync(
                            ticketForOrder, OrderSide.Sell, quantityForTwoOrders - 1, secondLimitPrice, stopPrice, stopLimitPrice,
                            null, null, null, null, null, TimeInForce.GoodTillCancel);


                    }
                    if (limitsQuantity_CB.Items[limitsQuantity_CB.SelectedIndex].ToString() == "3 limits")
                    {

                    }
                    if (limitsQuantity_CB.Items[limitsQuantity_CB.SelectedIndex].ToString() == "4 limits")
                    {

                    }*/



                    #endregion

                    if (!result2)
                    {
                        MessageBox.Show(result2.Error.Message);
                        return;
                    }
                    #endregion
                    #region Info about an order
                    #region Информация про успешность покупки и выставление ордера
                    this.coinBoughtProp_TB.Text = result1.Success.ToString();
                    this.sellIrderPlacedProp_TB.Text = result2.Success.ToString();
                    #endregion

                    #region Средняя цена входа и выставление ордера
                    // Средняя цена входа в рынок
                    decimal AverageFillPrice1 = result1.Data.AverageFillPrice.Value;

                    // Средняя цена выставления ордера
                    var AverageFillPrice2 = result2.Data.OrderReports;
                    BinanceOrderBase orderBase = new BinanceOrderBase();
                    foreach (var item in AverageFillPrice2)
                        orderBase.Price = item.Price;

                    this.enteredPrice_TB.Text = AverageFillPrice1.ToString();
                    this.limitOrderPrice_TB.Text = orderBase.Price.ToString();
                    #endregion

                    #region Асинхронно обновляем текущую цену и рассчитываем процент движения от покупки

                    currentPrice_TB.Invoke(new Action(() =>
                    {
                        SocketClient.Spot.SubscribeToOrderBookUpdates(ticketForOrder, 100, orderUpdate =>
                        {
                            var currentPriceCoin =
                            client.Spot.Market.GetPriceAsync(pumpingCoin_TB.Text).Result.Data.Price;

                            var procentSinceBought = Round(((1 - AverageFillPrice1 / currentPriceCoin) * 100), 3);

                            this.currentPrice_TB.Text = currentPriceCoin.ToString();
                            this.procentSinceBought_TB.Text = procentSinceBought.ToString() +
                             $"%  ({currentPriceCoin * quantityToEntry})";
                        });
                    }));

                    #endregion

                    #endregion
                }
                else
                {
                    MessageBox.Show("This coin is not for you...");
                    /* await client.Spot.Order.PlaceOrderAsync(ticketForOrder, OrderSide.Buy, OrderType.Market,
                         Round(quantityToEntry, 1), null, null, null, TimeInForce.GoodTillCancel);

                     var result2 = await client.Spot.Order.PlaceOrderAsync(
                               ticketForOrder, OrderSide.Sell, OrderType.Limit, quantityToEntry,
                               null, null, priceToClose);*/
                }

            }
            catch (Exception exc) { MessageBox.Show(exc.Message); }
            #endregion
           // MessageBox.Show($"Coin has bought in {stopwatch.Elapsed.TotalSeconds} sec");
        }

        /// <summary>
        /// Gets account info, such as balances, etc.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void getAccountInfo_Click(object sender, EventArgs e)
        {
            btcAsset_TB.ResetText();
            usdtAsset_TB.ResetText();
            var binanceBalances = await client.General.GetAccountInfoAsync();
            var balances = from t in binanceBalances.Data.Balances
                           where t.Asset.ToString() == "BTC" ||
                           t.Asset.ToString() == "USDT"
                           select t;

            foreach (var item in balances)
            {
                if (btcAsset_TB.Text == string.Empty || usdtAsset_TB.Text == string.Empty)
                {
                    if (item.Asset == "BTC") btcAsset_TB.Text = item.Free.ToString();
                    else usdtAsset_TB.Text = item.Free.ToString();
                }
                else break;
            }
            #region BtcToUsdt_ToolTip
            var prices = await client.Spot.Market.GetPricesAsync();
            var btcPrice = from b in prices.Data
                           where b.Symbol.ToString() == "BTCUSDT"
                           select b.Price;
            toolTip1.SetToolTip(btcAsset_TB,
                (Math.Round(btcPrice.First() * balances.First().Free, 2)).ToString()
                + " in USDT");
            #endregion
        }

        /// <summary>
        /// Gets the coin ticket, that is pumping.
        /// </summary>
        /// <returns>True, if reading is successful; false, if does not.</returns>
        private bool ReadCoinToPump()
        {
           
            #region 2 logics for reading a coin from two different channels
            try
            {
                if (this.coinToPumpTB.Text != string.Empty)
                {
                    #region Logic for @bigpumpsignal 
                    if (charToRead_CB.Items[charToRead_CB.SelectedIndex].ToString() == "$")
                    {
                        stringWithCoin = "";
                        stringWithCoin += this.coinToPumpTB.Text + ' ';

                        string coinWithRemovedLattice = stringWithCoin.Remove(0, stringWithCoin.IndexOf('$'));
                        coin = coinWithRemovedLattice.Remove(
                           coinWithRemovedLattice.IndexOf(' '),
                           coinWithRemovedLattice.Length - coinWithRemovedLattice.IndexOf(' '));

                        // В поле покупки тикета добавляем назву монеты и прибавляем базовую валюту. 
                        this.pumpingCoin_TB.Text = coin.Remove(coin.IndexOf('$'), 1).ToUpper() + "BTC";
                        return true;
                    }
                    #endregion
                    else
                    {


                        #region Logic for @mega_pump_group
                        if (charToRead_CB.Items[charToRead_CB.SelectedIndex].ToString() == "#")
                        {
                            stringWithCoin = "";
                            stringWithCoin += this.coinToPumpTB.Text + "\n";
                            string coinWithRemovedLattice = stringWithCoin.Remove(0, stringWithCoin.IndexOf('#'));
                            coin = coinWithRemovedLattice.Remove(
                                coinWithRemovedLattice.IndexOf("\n"),
                                coinWithRemovedLattice.Length - coinWithRemovedLattice.IndexOf("\n"));

                            // В поле покупки тикета добавляем назву монеты и прибавляем базовую валюту. 
                            this.pumpingCoin_TB.Text = coin.Remove(coin.IndexOf('#'), 1).ToUpper() + "BTC";
                            return true;
                        }
                        #endregion

                        #region Logic for @Binance Pump Signals

                        else
                        {
                            stringWithCoin = "";
                            stringWithCoin += this.coinToPumpTB.Text;

                            string coinWithRemovedLattice = stringWithCoin.Remove(0, stringWithCoin.IndexOf(':'));

                            if (stringWithCoin.IndexOf(": ") != -1)
                            {
                                coin = (stringWithCoin.Remove(0, stringWithCoin.IndexOf(":")).Replace(": ", "") + "BTC").Trim();
                            }
                            else
                            {
                                coin = (stringWithCoin.Remove(0, stringWithCoin.IndexOf(":")).Replace(":", "") + "BTC").Trim();
                            }


                            // В поле покупки тикета добавляем назву монеты и прибавляем базовую валюту. 
                            this.pumpingCoin_TB.Text = coin.ToUpper();
                            return true;
                        }
                    }
                    #endregion
                }
                else
                {
                    this.Text = "CANNOT READ!";
                    return false;
                }
            }
            catch (Exception exc)
            {
                this.Text = $"Something happened: {exc.Message}";
                return false;
            }
            #endregion
        }

        private async void getCoin_BTN_Click(object sender, EventArgs e)
        {
            #region Get hash and channel ID.
            /*coinToPumpTB.Text = string.Empty;

            var dialogs = await telegram_Client.GetUserDialogsAsync() as TLDialogsSlice;

            chat = dialogs.Chats
          .Where(c => c.GetType() == typeof(TLChannel))
          .Cast<TLChannel>()
          .FirstOrDefault(c => c.Title == "Mega Pump Group");*/
            // MessageBox.Show(chat.AccessHash.ToString());

            /*var chat2 = dialogs.Chats
          .Where(c => c.GetType() == typeof(TLChannel))
          .Cast<TLChannel>()
          .FirstOrDefault(c => c.Title == "Mega Pump Group");
            MessageBox.Show(chat2.AccessHash.ToString());*/
            #endregion

            if (comboBox1.Items[0] != null)
            {
                if (comboBox1.SelectedItem.ToString() == "Big Pump Signal ($)")
                    inputPeer = new TLInputPeerChannel { ChannelId = 1257721998, AccessHash = -8255524000268932485 };
                else
                {
                    if (comboBox1.SelectedItem.ToString() == "Mega Pump Group (#)")
                        inputPeer = new TLInputPeerChannel { ChannelId = 1297239210, AccessHash = 3761532579816821973 };

                    if (comboBox1.SelectedItem.ToString() == "PumpTest")
                        inputPeer = new TLInputPeerChannel { ChannelId = 1257460409, AccessHash = 4063759744540392889 };

                    if (comboBox1.SelectedItem.ToString() == "Binance Pump Signals")
                        inputPeer = new TLInputPeerChannel { ChannelId = 1219293084, AccessHash = 9031459035674228161 };
                }
            }
            else
            {
                MessageBox.Show("Put the group where coin is pumpuing");
                return;
            }
            history = (TLChannelMessages)await telegram_Client.GetHistoryAsync(inputPeer);
            mes = (TLMessage)history.Messages[0];
            //stringWithCoin += mes.Message;
            coinToPumpTB.Text += mes.Message;
        }

        private async void CancelOrderAndSell(object sender, EventArgs e)
        {
            string ticketForOrder = this.pumpingCoin_TB.Text;
            try
            {
                if (result2.Success)
                {
                    var res = await client.Spot.Order.CancelOcoOrderAsync(
                        ticketForOrder, result2.Data.OrderListId, result2.Data.ListClientOrderId);
                    if (res.Success)
                    {
                        this.Text = "Success";
                        var res2 = await client.Spot.Order.PlaceOrderAsync
                             (ticketForOrder, OrderSide.Sell, OrderType.Market, quantityToEntry - 1);
                        if (res2.Success) this.Text = "Success";
                        else MessageBox.Show("Cant sell...");
                    }
                    else MessageBox.Show("Something happened...");
                }
                else MessageBox.Show("Cannot cancel OCO order, because it does not exist.");
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.ToString());
            }

        }

        private void limitsQuantity_CB_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (limitsQuantity_CB.Items[limitsQuantity_CB.SelectedIndex].ToString() == string.Empty)
            {
                thirdLimit_TB.Visible = false;
                fourthLimit_TB.Visible = false;

                firstLimit_TB.Visible = false;
                secondLimit_TB.Visible = false;
            }
            if (limitsQuantity_CB.Items[limitsQuantity_CB.SelectedIndex].ToString() == "2 limits")
            {
                thirdLimit_TB.Visible = false;
                fourthLimit_TB.Visible = false;

                firstLimit_TB.Visible = true;
                secondLimit_TB.Visible = true;
            }
            if (limitsQuantity_CB.Items[limitsQuantity_CB.SelectedIndex].ToString() == "3 limits")
            {
                fourthLimit_TB.Visible = false;

                firstLimit_TB.Visible = true;
                secondLimit_TB.Visible = true;
                thirdLimit_TB.Visible = true;
            }
            if (limitsQuantity_CB.Items[limitsQuantity_CB.SelectedIndex].ToString() == "4 limits")
            {
                firstLimit_TB.Visible = true;
                secondLimit_TB.Visible = true;
                thirdLimit_TB.Visible = true;
                fourthLimit_TB.Visible = true;
            }
        }

        private void clearAllInfo_BTN_Click(object sender, EventArgs e)
        {
            SocketClient.UnsubscribeAll();
            coinToPumpTB.Clear();
            pumpingCoin_TB.Clear();
            coinToPumpTB.Clear();
            sellIrderPlacedProp_TB.Clear();
            enteredPrice_TB.Clear();
            coinBoughtProp_TB.Clear();
            limitOrderPrice_TB.Clear();
            currentPrice_TB.Clear();
            procentSinceBought_TB.Clear();
        }
        #endregion



        #region Menu logic
        private void ConnectToBinance_TSM_Click(object sender, System.EventArgs e)
        {
            ConnectionToBinance apiConnection = new ConnectionToBinance();
            apiConnection.ShowDialog();
        }

        private void ConnectToTelegram_TSM_Click(object sender, EventArgs e)
        {
            ConnectionToTelegram telegram = new ConnectionToTelegram();
            telegram.ShowDialog();

        }

        private void DisconnectTelegram_TSM_Click(object sender, EventArgs e)
        {
            try { DisconnectTelegram(); }
            catch (Exception exc) { MessageBox.Show(exc.Message); }
        }

        private void DisconnectBinance_TSM_Click(object sender, System.EventArgs e)
        {
            try { DisconnectBinance(); }
            catch (Exception exc) { MessageBox.Show(exc.Message); }
        }

        private void DisconnectAll_TSM_Click(object sender, System.EventArgs e)
        {
            try { DisconnectTelegram(); DisconnectBinance(); }
            catch (Exception exc) { MessageBox.Show(exc.Message); }
        }

        private void DisconnectBinance()
        {
            if (MessageBox.Show("This will delete all telegram configuration.\n" +
           "Are you sure?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Properties.Settings.Default.apiKey = null;
                Properties.Settings.Default.apiSecret = null;
                Properties.Settings.Default.Save();
                Thread.Sleep(100);
                this.Text = "Success";
            }
            else this.Text = "It's your decision...";
        }

        private void DisconnectTelegram()
        {
            if (MessageBox.Show("This will delete all telegram configuration.\n" +
               "Are you sure?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Properties.Settings.Default.apiID_Telegram = 0;
                Properties.Settings.Default.apiHash_Telegram = null;
                Properties.Settings.Default.number_Telegram = null;
                Properties.Settings.Default.Save();
                Thread.Sleep(100);
                this.Text = "Success";
            }
            else this.Text = "It's your decision...";
        }

        /// <summary>
        /// Optional info to be informed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_Click(object sender, EventArgs e)
        {
            this.Text = "PumpBot";
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            TextBox.CheckForIllegalCrossThreadCalls = false;
            UpdatePriceAsync();
        }
        #endregion

        #region Outdated Telegram Logic
        /*private async void ConnectTelegram_BTN_Click(object sender, EventArgs e)
        {
            await telegram_Client.ConnectAsync();

            hash = await telegram_Client.SendCodeRequestAsync(user_number);
        }
        private async void sendCode_OK_BTN_ClickAsync(object sender, EventArgs e)
        {
            string code_from_telegram = this.textBox1.Text;

            await telegram_Client.MakeAuthAsync(user_number, hash, code_from_telegram);
        }*/
        #endregion
    }
}