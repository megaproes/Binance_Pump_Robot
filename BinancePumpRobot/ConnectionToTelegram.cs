using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Binance.Net.Objects.Shared;
using TeleSharp.TL;
using TeleSharp.TL.Channels;
using TeleSharp.TL.Messages;
using TLSharp;

using TLSharp.Core;

namespace BinancePumpRobot
{
    public partial class ConnectionToTelegram : Form
    {
        #region Instances and variables
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
        public ConnectionToTelegram()
        {
            InitializeComponent();

            /* telegram_Client = new TelegramClient(apiId, apiHash, null, "sessionSUKA");
             telegram_Client.ConnectAsync();*/
        }
        private void configurate_BTN_Click(object sender, EventArgs e)
        {
            try
            {
                apiId = int.Parse(this.apiID_TB.Text);
                apiHash = this.apiHash_TB.Text;
                if (apiId != 0 && apiHash != string.Empty)
                {
                    Properties.Settings.Default.apiID_Telegram = apiId;
                    Properties.Settings.Default.apiHash_Telegram = apiHash;
                    Properties.Settings.Default.Save();
                    this.Text = "Success!";
                }
                else MessageBox.Show("Configuration failed");
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        private async void connect_BTN_Click(object sender, EventArgs e)
        {
            try
            {
                telegram_Client = new TelegramClient(apiId, apiHash, null, "sessionSUKA");
                await telegram_Client.ConnectAsync();
                user_number = this.phoneNumber_TB.Text;
                if (user_number != string.Empty)
                {
                    hash = await telegram_Client.SendCodeRequestAsync(user_number);
                    Properties.Settings.Default.number_Telegram = user_number;
                    Properties.Settings.Default.Save();
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }

        }

        private async void sendCode_BTN_Click(object sender, EventArgs e)
        {
            try
            {
                string code_from_telegram = this.codeFromTelegram_TB.Text;

                await telegram_Client.MakeAuthAsync(user_number, hash, code_from_telegram);
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }

        }
    }
}

