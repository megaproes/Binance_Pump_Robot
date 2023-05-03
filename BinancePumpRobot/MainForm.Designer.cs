
namespace BinancePumpRobot
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.coinToPumpTB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.clearAllInfo_BTN = new System.Windows.Forms.Button();
            this.stopLoss_TB = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.limitOrderPrice_TB = new System.Windows.Forms.TextBox();
            this.currentPrice_TB = new System.Windows.Forms.TextBox();
            this.enteredPrice_TB = new System.Windows.Forms.TextBox();
            this.sellIrderPlacedProp_TB = new System.Windows.Forms.TextBox();
            this.coinBoughtProp_TB = new System.Windows.Forms.TextBox();
            this.pumpingCoin_TB = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.procentToEarn_TB = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.assetToPump_TB = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.currencyToPut_CB = new System.Windows.Forms.ComboBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label13 = new System.Windows.Forms.Label();
            this.BTCUSDT_Price_TB = new System.Windows.Forms.TextBox();
            this.usdtAsset_TB = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.btcAsset_TB = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.getAccountInfo = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.procentSinceBought_TB = new System.Windows.Forms.TextBox();
            this.charToRead_CB = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.File_TSM = new System.Windows.Forms.ToolStripMenuItem();
            this.connectToTelegram_TSM = new System.Windows.Forms.ToolStripMenuItem();
            this.connectToBinance_TSM = new System.Windows.Forms.ToolStripMenuItem();
            this.PumpResults_TSM = new System.Windows.Forms.ToolStripMenuItem();
            this.CheckConnection_TSM = new System.Windows.Forms.ToolStripMenuItem();
            this.disconnectTelegram_TSM = new System.Windows.Forms.ToolStripMenuItem();
            this.disconnectBinance_TSM = new System.Windows.Forms.ToolStripMenuItem();
            this.disconnectAll_TSM = new System.Windows.Forms.ToolStripMenuItem();
            this.getCoin_BTN = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.fourthLimit_TB = new System.Windows.Forms.TextBox();
            this.thirdLimit_TB = new System.Windows.Forms.TextBox();
            this.secondLimit_TB = new System.Windows.Forms.TextBox();
            this.firstLimit_TB = new System.Windows.Forms.TextBox();
            this.limitsQuantity_CB = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.coinToPumpTB);
            this.panel1.Location = new System.Drawing.Point(1, 44);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(142, 210);
            this.panel1.TabIndex = 0;
            // 
            // coinToPumpTB
            // 
            this.coinToPumpTB.BackColor = System.Drawing.Color.LightSteelBlue;
            this.coinToPumpTB.Location = new System.Drawing.Point(0, 0);
            this.coinToPumpTB.Multiline = true;
            this.coinToPumpTB.Name = "coinToPumpTB";
            this.coinToPumpTB.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.coinToPumpTB.Size = new System.Drawing.Size(142, 210);
            this.coinToPumpTB.TabIndex = 1;
            this.coinToPumpTB.TextChanged += new System.EventHandler(this.coinToPumpTB_TextChanged);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.HotPink;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(0, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Coin in text";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.panel2.Controls.Add(this.clearAllInfo_BTN);
            this.panel2.Controls.Add(this.stopLoss_TB);
            this.panel2.Controls.Add(this.label14);
            this.panel2.Controls.Add(this.limitOrderPrice_TB);
            this.panel2.Controls.Add(this.currentPrice_TB);
            this.panel2.Controls.Add(this.enteredPrice_TB);
            this.panel2.Controls.Add(this.sellIrderPlacedProp_TB);
            this.panel2.Controls.Add(this.coinBoughtProp_TB);
            this.panel2.Controls.Add(this.pumpingCoin_TB);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.textBox3);
            this.panel2.Controls.Add(this.procentToEarn_TB);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.assetToPump_TB);
            this.panel2.Controls.Add(this.label2);
            this.panel2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel2.Location = new System.Drawing.Point(125, 27);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 227);
            this.panel2.TabIndex = 1;
            // 
            // clearAllInfo_BTN
            // 
            this.clearAllInfo_BTN.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.clearAllInfo_BTN.ForeColor = System.Drawing.Color.DarkViolet;
            this.clearAllInfo_BTN.Location = new System.Drawing.Point(147, 204);
            this.clearAllInfo_BTN.Name = "clearAllInfo_BTN";
            this.clearAllInfo_BTN.Size = new System.Drawing.Size(53, 23);
            this.clearAllInfo_BTN.TabIndex = 31;
            this.clearAllInfo_BTN.Text = "Clear";
            this.clearAllInfo_BTN.UseVisualStyleBackColor = true;
            this.clearAllInfo_BTN.Click += new System.EventHandler(this.clearAllInfo_BTN_Click);
            // 
            // stopLoss_TB
            // 
            this.stopLoss_TB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.stopLoss_TB.BackColor = System.Drawing.Color.Crimson;
            this.stopLoss_TB.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.stopLoss_TB.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.stopLoss_TB.Location = new System.Drawing.Point(133, 15);
            this.stopLoss_TB.Multiline = true;
            this.stopLoss_TB.Name = "stopLoss_TB";
            this.stopLoss_TB.Size = new System.Drawing.Size(47, 24);
            this.stopLoss_TB.TabIndex = 30;
            // 
            // label14
            // 
            this.label14.Location = new System.Drawing.Point(147, -3);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(22, 24);
            this.label14.TabIndex = 29;
            this.label14.Text = "SL";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // limitOrderPrice_TB
            // 
            this.limitOrderPrice_TB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.limitOrderPrice_TB.BackColor = System.Drawing.Color.Crimson;
            this.limitOrderPrice_TB.Font = new System.Drawing.Font("Times New Roman", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.limitOrderPrice_TB.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.limitOrderPrice_TB.Location = new System.Drawing.Point(112, 115);
            this.limitOrderPrice_TB.Multiline = true;
            this.limitOrderPrice_TB.Name = "limitOrderPrice_TB";
            this.limitOrderPrice_TB.Size = new System.Drawing.Size(78, 16);
            this.limitOrderPrice_TB.TabIndex = 28;
            this.limitOrderPrice_TB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // currentPrice_TB
            // 
            this.currentPrice_TB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.currentPrice_TB.BackColor = System.Drawing.Color.Crimson;
            this.currentPrice_TB.Font = new System.Drawing.Font("Times New Roman", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.currentPrice_TB.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.currentPrice_TB.Location = new System.Drawing.Point(112, 131);
            this.currentPrice_TB.Multiline = true;
            this.currentPrice_TB.Name = "currentPrice_TB";
            this.currentPrice_TB.Size = new System.Drawing.Size(78, 16);
            this.currentPrice_TB.TabIndex = 27;
            this.currentPrice_TB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // enteredPrice_TB
            // 
            this.enteredPrice_TB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.enteredPrice_TB.BackColor = System.Drawing.Color.Crimson;
            this.enteredPrice_TB.Font = new System.Drawing.Font("Times New Roman", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.enteredPrice_TB.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.enteredPrice_TB.Location = new System.Drawing.Point(112, 99);
            this.enteredPrice_TB.Multiline = true;
            this.enteredPrice_TB.Name = "enteredPrice_TB";
            this.enteredPrice_TB.Size = new System.Drawing.Size(78, 16);
            this.enteredPrice_TB.TabIndex = 25;
            this.enteredPrice_TB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // sellIrderPlacedProp_TB
            // 
            this.sellIrderPlacedProp_TB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.sellIrderPlacedProp_TB.BackColor = System.Drawing.Color.Crimson;
            this.sellIrderPlacedProp_TB.Font = new System.Drawing.Font("Times New Roman", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.sellIrderPlacedProp_TB.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.sellIrderPlacedProp_TB.Location = new System.Drawing.Point(112, 83);
            this.sellIrderPlacedProp_TB.Multiline = true;
            this.sellIrderPlacedProp_TB.Name = "sellIrderPlacedProp_TB";
            this.sellIrderPlacedProp_TB.Size = new System.Drawing.Size(78, 16);
            this.sellIrderPlacedProp_TB.TabIndex = 24;
            this.sellIrderPlacedProp_TB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // coinBoughtProp_TB
            // 
            this.coinBoughtProp_TB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.coinBoughtProp_TB.BackColor = System.Drawing.Color.Crimson;
            this.coinBoughtProp_TB.Font = new System.Drawing.Font("Times New Roman", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.coinBoughtProp_TB.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.coinBoughtProp_TB.Location = new System.Drawing.Point(112, 67);
            this.coinBoughtProp_TB.Multiline = true;
            this.coinBoughtProp_TB.Name = "coinBoughtProp_TB";
            this.coinBoughtProp_TB.Size = new System.Drawing.Size(78, 16);
            this.coinBoughtProp_TB.TabIndex = 23;
            this.coinBoughtProp_TB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pumpingCoin_TB
            // 
            this.pumpingCoin_TB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pumpingCoin_TB.BackColor = System.Drawing.Color.Crimson;
            this.pumpingCoin_TB.Font = new System.Drawing.Font("Times New Roman", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.pumpingCoin_TB.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.pumpingCoin_TB.Location = new System.Drawing.Point(112, 51);
            this.pumpingCoin_TB.Multiline = true;
            this.pumpingCoin_TB.Name = "pumpingCoin_TB";
            this.pumpingCoin_TB.Size = new System.Drawing.Size(78, 16);
            this.pumpingCoin_TB.TabIndex = 22;
            this.pumpingCoin_TB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.Color.Cornsilk;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label9.Location = new System.Drawing.Point(0, 131);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(113, 15);
            this.label9.TabIndex = 21;
            this.label9.Text = "Current price: ";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.Cornsilk;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label8.Location = new System.Drawing.Point(0, 115);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(113, 16);
            this.label8.TabIndex = 20;
            this.label8.Text = "Limit order price: ";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.Cornsilk;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label7.Location = new System.Drawing.Point(0, 99);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(113, 16);
            this.label7.TabIndex = 19;
            this.label7.Text = "Buy price: ";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.Cornsilk;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label6.Location = new System.Drawing.Point(0, 83);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(113, 16);
            this.label6.TabIndex = 18;
            this.label6.Text = "SellOrderPlaced: ";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Cornsilk;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label5.Location = new System.Drawing.Point(0, 67);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(113, 16);
            this.label5.TabIndex = 17;
            this.label5.Text = "Coin_Bought: ";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Cornsilk;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label4.Location = new System.Drawing.Point(0, 51);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 16);
            this.label4.TabIndex = 2;
            this.label4.Text = "Coin pumping: ";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.SystemColors.InfoText;
            this.textBox3.Location = new System.Drawing.Point(0, 38);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(194, 10);
            this.textBox3.TabIndex = 16;
            this.textBox3.Text = "--------------------------------------------";
            // 
            // procentToEarn_TB
            // 
            this.procentToEarn_TB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.procentToEarn_TB.BackColor = System.Drawing.Color.Crimson;
            this.procentToEarn_TB.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.procentToEarn_TB.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.procentToEarn_TB.Location = new System.Drawing.Point(66, 15);
            this.procentToEarn_TB.Multiline = true;
            this.procentToEarn_TB.Name = "procentToEarn_TB";
            this.procentToEarn_TB.Size = new System.Drawing.Size(47, 24);
            this.procentToEarn_TB.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(75, -1);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 18);
            this.label3.TabIndex = 14;
            this.label3.Text = "TP";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // assetToPump_TB
            // 
            this.assetToPump_TB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.assetToPump_TB.BackColor = System.Drawing.Color.Crimson;
            this.assetToPump_TB.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.assetToPump_TB.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.assetToPump_TB.Location = new System.Drawing.Point(-4, 14);
            this.assetToPump_TB.Multiline = true;
            this.assetToPump_TB.Name = "assetToPump_TB";
            this.assetToPump_TB.Size = new System.Drawing.Size(52, 24);
            this.assetToPump_TB.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(0, -3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 23);
            this.label2.TabIndex = 0;
            this.label2.Text = "Asset";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // currencyToPut_CB
            // 
            this.currencyToPut_CB.FormattingEnabled = true;
            this.currencyToPut_CB.Items.AddRange(new object[] {
            "BTC",
            "USDT"});
            this.currencyToPut_CB.Location = new System.Drawing.Point(764, 110);
            this.currencyToPut_CB.Name = "currencyToPut_CB";
            this.currencyToPut_CB.Size = new System.Drawing.Size(42, 23);
            this.currencyToPut_CB.TabIndex = 3;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.SpringGreen;
            this.panel3.Controls.Add(this.label13);
            this.panel3.Controls.Add(this.BTCUSDT_Price_TB);
            this.panel3.Controls.Add(this.usdtAsset_TB);
            this.panel3.Controls.Add(this.label12);
            this.panel3.Controls.Add(this.btcAsset_TB);
            this.panel3.Controls.Add(this.label11);
            this.panel3.Location = new System.Drawing.Point(653, 27);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(153, 66);
            this.panel3.TabIndex = 2;
            // 
            // label13
            // 
            this.label13.BackColor = System.Drawing.Color.Cornsilk;
            this.label13.Font = new System.Drawing.Font("Times New Roman", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label13.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label13.Location = new System.Drawing.Point(0, 12);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(65, 16);
            this.label13.TabIndex = 33;
            this.label13.Text = "BTC/USDT";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // BTCUSDT_Price_TB
            // 
            this.BTCUSDT_Price_TB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BTCUSDT_Price_TB.BackColor = System.Drawing.Color.Crimson;
            this.BTCUSDT_Price_TB.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BTCUSDT_Price_TB.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.BTCUSDT_Price_TB.Location = new System.Drawing.Point(64, 12);
            this.BTCUSDT_Price_TB.Multiline = true;
            this.BTCUSDT_Price_TB.Name = "BTCUSDT_Price_TB";
            this.BTCUSDT_Price_TB.Size = new System.Drawing.Size(78, 16);
            this.BTCUSDT_Price_TB.TabIndex = 34;
            // 
            // usdtAsset_TB
            // 
            this.usdtAsset_TB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.usdtAsset_TB.BackColor = System.Drawing.Color.Crimson;
            this.usdtAsset_TB.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.usdtAsset_TB.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.usdtAsset_TB.Location = new System.Drawing.Point(64, 47);
            this.usdtAsset_TB.Multiline = true;
            this.usdtAsset_TB.Name = "usdtAsset_TB";
            this.usdtAsset_TB.Size = new System.Drawing.Size(78, 16);
            this.usdtAsset_TB.TabIndex = 32;
            // 
            // label12
            // 
            this.label12.BackColor = System.Drawing.Color.Cornsilk;
            this.label12.Font = new System.Drawing.Font("Times New Roman", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label12.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label12.Location = new System.Drawing.Point(0, 31);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(48, 16);
            this.label12.TabIndex = 29;
            this.label12.Text = "BTC";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btcAsset_TB
            // 
            this.btcAsset_TB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btcAsset_TB.BackColor = System.Drawing.Color.Crimson;
            this.btcAsset_TB.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btcAsset_TB.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btcAsset_TB.Location = new System.Drawing.Point(64, 31);
            this.btcAsset_TB.Multiline = true;
            this.btcAsset_TB.Name = "btcAsset_TB";
            this.btcAsset_TB.Size = new System.Drawing.Size(78, 16);
            this.btcAsset_TB.TabIndex = 31;
            // 
            // label11
            // 
            this.label11.BackColor = System.Drawing.Color.Cornsilk;
            this.label11.Font = new System.Drawing.Font("Times New Roman", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label11.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label11.Location = new System.Drawing.Point(0, 47);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(48, 16);
            this.label11.TabIndex = 30;
            this.label11.Text = "USDT";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label10
            // 
            this.label10.BackColor = System.Drawing.Color.Cornsilk;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label10.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label10.Location = new System.Drawing.Point(664, 8);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(142, 16);
            this.label10.TabIndex = 2;
            this.label10.Text = "BTC/USDT balances";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // getAccountInfo
            // 
            this.getAccountInfo.Font = new System.Drawing.Font("Segoe UI", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.getAccountInfo.Location = new System.Drawing.Point(736, 93);
            this.getAccountInfo.Name = "getAccountInfo";
            this.getAccountInfo.Size = new System.Drawing.Size(50, 21);
            this.getAccountInfo.TabIndex = 33;
            this.getAccountInfo.Text = "Get info";
            this.getAccountInfo.UseVisualStyleBackColor = true;
            this.getAccountInfo.Click += new System.EventHandler(this.getAccountInfo_Click);
            // 
            // procentSinceBought_TB
            // 
            this.procentSinceBought_TB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.procentSinceBought_TB.BackColor = System.Drawing.Color.DarkOrchid;
            this.procentSinceBought_TB.Cursor = System.Windows.Forms.Cursors.Help;
            this.procentSinceBought_TB.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.procentSinceBought_TB.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.procentSinceBought_TB.Location = new System.Drawing.Point(654, 218);
            this.procentSinceBought_TB.Multiline = true;
            this.procentSinceBought_TB.Name = "procentSinceBought_TB";
            this.procentSinceBought_TB.ReadOnly = true;
            this.procentSinceBought_TB.Size = new System.Drawing.Size(152, 33);
            this.procentSinceBought_TB.TabIndex = 3;
            this.procentSinceBought_TB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // charToRead_CB
            // 
            this.charToRead_CB.FormattingEnabled = true;
            this.charToRead_CB.Items.AddRange(new object[] {
            "$",
            "#",
            ":"});
            this.charToRead_CB.Location = new System.Drawing.Point(764, 133);
            this.charToRead_CB.Name = "charToRead_CB";
            this.charToRead_CB.Size = new System.Drawing.Size(42, 23);
            this.charToRead_CB.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Crimson;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.SystemColors.Desktop;
            this.button1.Location = new System.Drawing.Point(325, 26);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(101, 39);
            this.button1.TabIndex = 34;
            this.button1.Text = "Market close";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.CancelOrderAndSell);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.File_TSM});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(806, 24);
            this.menuStrip1.TabIndex = 35;
            this.menuStrip1.Text = "General";
            // 
            // File_TSM
            // 
            this.File_TSM.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.connectToTelegram_TSM,
            this.connectToBinance_TSM,
            this.PumpResults_TSM,
            this.CheckConnection_TSM,
            this.disconnectTelegram_TSM,
            this.disconnectBinance_TSM,
            this.disconnectAll_TSM});
            this.File_TSM.Name = "File_TSM";
            this.File_TSM.Size = new System.Drawing.Size(37, 20);
            this.File_TSM.Text = "File";
            // 
            // connectToTelegram_TSM
            // 
            this.connectToTelegram_TSM.Name = "connectToTelegram_TSM";
            this.connectToTelegram_TSM.Size = new System.Drawing.Size(185, 22);
            this.connectToTelegram_TSM.Text = "Connect to Telegram";
            this.connectToTelegram_TSM.Click += new System.EventHandler(this.ConnectToTelegram_TSM_Click);
            // 
            // connectToBinance_TSM
            // 
            this.connectToBinance_TSM.Name = "connectToBinance_TSM";
            this.connectToBinance_TSM.Size = new System.Drawing.Size(185, 22);
            this.connectToBinance_TSM.Text = "Connect to Binance";
            this.connectToBinance_TSM.Click += new System.EventHandler(this.ConnectToBinance_TSM_Click);
            // 
            // PumpResults_TSM
            // 
            this.PumpResults_TSM.Name = "PumpResults_TSM";
            this.PumpResults_TSM.Size = new System.Drawing.Size(185, 22);
            this.PumpResults_TSM.Text = "Pump Results";
            // 
            // CheckConnection_TSM
            // 
            this.CheckConnection_TSM.Name = "CheckConnection_TSM";
            this.CheckConnection_TSM.Size = new System.Drawing.Size(185, 22);
            this.CheckConnection_TSM.Text = "Check Connection";
            // 
            // disconnectTelegram_TSM
            // 
            this.disconnectTelegram_TSM.Name = "disconnectTelegram_TSM";
            this.disconnectTelegram_TSM.Size = new System.Drawing.Size(185, 22);
            this.disconnectTelegram_TSM.Text = "Disconnect Telegram";
            this.disconnectTelegram_TSM.Click += new System.EventHandler(this.DisconnectTelegram_TSM_Click);
            // 
            // disconnectBinance_TSM
            // 
            this.disconnectBinance_TSM.Name = "disconnectBinance_TSM";
            this.disconnectBinance_TSM.Size = new System.Drawing.Size(185, 22);
            this.disconnectBinance_TSM.Text = "Disconnect Binance";
            this.disconnectBinance_TSM.Click += new System.EventHandler(this.DisconnectBinance_TSM_Click);
            // 
            // disconnectAll_TSM
            // 
            this.disconnectAll_TSM.Name = "disconnectAll_TSM";
            this.disconnectAll_TSM.Size = new System.Drawing.Size(185, 22);
            this.disconnectAll_TSM.Text = "Disconnect All";
            this.disconnectAll_TSM.Click += new System.EventHandler(this.DisconnectAll_TSM_Click);
            // 
            // getCoin_BTN
            // 
            this.getCoin_BTN.Location = new System.Drawing.Point(325, 145);
            this.getCoin_BTN.Name = "getCoin_BTN";
            this.getCoin_BTN.Size = new System.Drawing.Size(101, 109);
            this.getCoin_BTN.TabIndex = 36;
            this.getCoin_BTN.Text = "GetCoin";
            this.getCoin_BTN.UseVisualStyleBackColor = true;
            this.getCoin_BTN.Click += new System.EventHandler(this.getCoin_BTN_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.Color.DarkOrange;
            this.comboBox1.Font = new System.Drawing.Font("Segoe UI", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Big Pump Signal ($)",
            "Mega Pump Group (#)",
            "PumpTest",
            "Binance Pump Signals"});
            this.comboBox1.Location = new System.Drawing.Point(694, 158);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(112, 20);
            this.comboBox1.TabIndex = 40;
            // 
            // fourthLimit_TB
            // 
            this.fourthLimit_TB.Location = new System.Drawing.Point(553, 226);
            this.fourthLimit_TB.Multiline = true;
            this.fourthLimit_TB.Name = "fourthLimit_TB";
            this.fourthLimit_TB.Size = new System.Drawing.Size(96, 24);
            this.fourthLimit_TB.TabIndex = 59;
            this.fourthLimit_TB.Visible = false;
            // 
            // thirdLimit_TB
            // 
            this.thirdLimit_TB.Location = new System.Drawing.Point(553, 202);
            this.thirdLimit_TB.Multiline = true;
            this.thirdLimit_TB.Name = "thirdLimit_TB";
            this.thirdLimit_TB.Size = new System.Drawing.Size(96, 24);
            this.thirdLimit_TB.TabIndex = 58;
            this.thirdLimit_TB.Visible = false;
            // 
            // secondLimit_TB
            // 
            this.secondLimit_TB.Location = new System.Drawing.Point(553, 180);
            this.secondLimit_TB.Multiline = true;
            this.secondLimit_TB.Name = "secondLimit_TB";
            this.secondLimit_TB.Size = new System.Drawing.Size(96, 24);
            this.secondLimit_TB.TabIndex = 57;
            this.secondLimit_TB.Visible = false;
            // 
            // firstLimit_TB
            // 
            this.firstLimit_TB.Location = new System.Drawing.Point(553, 158);
            this.firstLimit_TB.Multiline = true;
            this.firstLimit_TB.Name = "firstLimit_TB";
            this.firstLimit_TB.Size = new System.Drawing.Size(96, 24);
            this.firstLimit_TB.TabIndex = 56;
            this.firstLimit_TB.Visible = false;
            // 
            // limitsQuantity_CB
            // 
            this.limitsQuantity_CB.FormattingEnabled = true;
            this.limitsQuantity_CB.Items.AddRange(new object[] {
            "",
            "2 limits",
            "3 limits",
            "4 limits"});
            this.limitsQuantity_CB.Location = new System.Drawing.Point(729, 180);
            this.limitsQuantity_CB.Name = "limitsQuantity_CB";
            this.limitsQuantity_CB.Size = new System.Drawing.Size(77, 23);
            this.limitsQuantity_CB.TabIndex = 55;
            this.limitsQuantity_CB.SelectedIndexChanged += new System.EventHandler(this.limitsQuantity_CB_SelectedIndexChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkBlue;
            this.ClientSize = new System.Drawing.Size(806, 253);
            this.Controls.Add(this.fourthLimit_TB);
            this.Controls.Add(this.thirdLimit_TB);
            this.Controls.Add(this.secondLimit_TB);
            this.Controls.Add(this.firstLimit_TB);
            this.Controls.Add(this.limitsQuantity_CB);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.getCoin_BTN);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.getAccountInfo);
            this.Controls.Add(this.currencyToPut_CB);
            this.Controls.Add(this.charToRead_CB);
            this.Controls.Add(this.procentSinceBought_TB);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "PumpBot";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Click += new System.EventHandler(this.Form1_Click);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

       







        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox coinToPumpTB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox procentToEarn_TB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox assetToPump_TB;
        private System.Windows.Forms.TextBox limitOrderPrice_TB;
        private System.Windows.Forms.TextBox currentPrice_TB;
        private System.Windows.Forms.TextBox enteredPrice_TB;
        private System.Windows.Forms.TextBox sellIrderPlacedProp_TB;
        private System.Windows.Forms.TextBox coinBoughtProp_TB;
        private System.Windows.Forms.TextBox pumpingCoin_TB;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button getAccountInfo;
        private System.Windows.Forms.TextBox usdtAsset_TB;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox btcAsset_TB;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ComboBox currencyToPut_CB;
        private System.Windows.Forms.TextBox procentSinceBought_TB;
        private System.Windows.Forms.ComboBox charToRead_CB;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox BTCUSDT_Price_TB;
        private System.Windows.Forms.TextBox stopLoss_TB;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem File_TSM;
        private System.Windows.Forms.ToolStripMenuItem connectToBinance_TSM;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem CheckConnection_TSM;
        private System.Windows.Forms.ToolStripMenuItem PumpResults_TSM;
        private System.Windows.Forms.Button getCoin_BTN;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox fourthLimit_TB;
        private System.Windows.Forms.TextBox thirdLimit_TB;
        private System.Windows.Forms.TextBox secondLimit_TB;
        private System.Windows.Forms.TextBox firstLimit_TB;
        private System.Windows.Forms.ComboBox limitsQuantity_CB;
        private System.Windows.Forms.Button clearAllInfo_BTN;
        private System.Windows.Forms.ToolStripMenuItem connectToTelegram_TSM;
        private System.Windows.Forms.ToolStripMenuItem disconnectTelegram_TSM;
        private System.Windows.Forms.ToolStripMenuItem disconnectBinance_TSM;
        private System.Windows.Forms.ToolStripMenuItem disconnectAll_TSM;
    }
}

