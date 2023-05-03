using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Binance.Net.Objects.Spot;
using CryptoExchange.Net.Authentication;
using Binance.Net;
using CryptoExchange.Net.Objects;
using BinancePumpRobot.Properties;

namespace BinancePumpRobot
{
    public partial class ConnectionToBinance : Form
    {
        public ConnectionToBinance()
        {
            InitializeComponent();
        }

        private void connect_BTN_Click(object sender, EventArgs e)
        {
            using (BinanceClient client = new BinanceClient())
            {
                bool cond1 = apiKey_TB.Text != string.Empty || apiSecret_TB.Text != string.Empty;
                bool cond2 = apiKey_TB.Text.Length == 64 && apiSecret_TB.Text.Length == 64;
                bool cond3 = default;
                if (cond1 && cond2)
                {
                    client.SetApiCredentials(this.apiKey_TB.Text, this.apiSecret_TB.Text);
                    WebCallResult<string> startResult = client.Spot.UserStream.StartUserStream();

                    cond3 = startResult == true;
                    if (cond3)
                    {
                        Settings.Default.apiKey = apiKey_TB.Text;
                        Settings.Default.apiSecret = apiSecret_TB.Text;
                        Settings.Default.Save();
                        MessageBox.Show("Success!");
                    }
                    else
                    {
                        MessageBox.Show("Keys are not correct. Try to recreate them.");
                    }
                }
                else
                {
                        MessageBox.Show("Keys are empty or less than 64 digits!");
                }
                
            }
        }
    }
}
