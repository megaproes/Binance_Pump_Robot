
namespace BinancePumpRobot
{
    partial class ConnectionToTelegram
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.connect_BTN = new System.Windows.Forms.Button();
            this.apiSecret_Label = new System.Windows.Forms.Label();
            this.apiKey_Label = new System.Windows.Forms.Label();
            this.codeFromTelegram_TB = new System.Windows.Forms.TextBox();
            this.phoneNumber_TB = new System.Windows.Forms.TextBox();
            this.sendCode_BTN = new System.Windows.Forms.Button();
            this.apiHash_Label = new System.Windows.Forms.Label();
            this.apiID_Label = new System.Windows.Forms.Label();
            this.apiHash_TB = new System.Windows.Forms.TextBox();
            this.apiID_TB = new System.Windows.Forms.TextBox();
            this.configurate_BTN = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // connect_BTN
            // 
            this.connect_BTN.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.connect_BTN.Font = new System.Drawing.Font("Segoe UI", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.connect_BTN.Location = new System.Drawing.Point(212, 90);
            this.connect_BTN.Name = "connect_BTN";
            this.connect_BTN.Size = new System.Drawing.Size(68, 22);
            this.connect_BTN.TabIndex = 25;
            this.connect_BTN.Text = "Send code";
            this.connect_BTN.UseVisualStyleBackColor = true;
            this.connect_BTN.Click += new System.EventHandler(this.connect_BTN_Click);
            // 
            // apiSecret_Label
            // 
            this.apiSecret_Label.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.apiSecret_Label.BackColor = System.Drawing.Color.Cornsilk;
            this.apiSecret_Label.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.apiSecret_Label.ForeColor = System.Drawing.SystemColors.ControlText;
            this.apiSecret_Label.Location = new System.Drawing.Point(0, 117);
            this.apiSecret_Label.Name = "apiSecret_Label";
            this.apiSecret_Label.Size = new System.Drawing.Size(76, 16);
            this.apiSecret_Label.TabIndex = 24;
            this.apiSecret_Label.Text = "Code";
            this.apiSecret_Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // apiKey_Label
            // 
            this.apiKey_Label.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.apiKey_Label.BackColor = System.Drawing.Color.Cornsilk;
            this.apiKey_Label.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.apiKey_Label.ForeColor = System.Drawing.SystemColors.ControlText;
            this.apiKey_Label.Location = new System.Drawing.Point(0, 96);
            this.apiKey_Label.Name = "apiKey_Label";
            this.apiKey_Label.Size = new System.Drawing.Size(76, 16);
            this.apiKey_Label.TabIndex = 23;
            this.apiKey_Label.Text = "Number";
            this.apiKey_Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // codeFromTelegram_TB
            // 
            this.codeFromTelegram_TB.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.codeFromTelegram_TB.BackColor = System.Drawing.Color.DodgerBlue;
            this.codeFromTelegram_TB.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.codeFromTelegram_TB.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.codeFromTelegram_TB.Location = new System.Drawing.Point(93, 117);
            this.codeFromTelegram_TB.Multiline = true;
            this.codeFromTelegram_TB.Name = "codeFromTelegram_TB";
            this.codeFromTelegram_TB.Size = new System.Drawing.Size(113, 16);
            this.codeFromTelegram_TB.TabIndex = 22;
            // 
            // phoneNumber_TB
            // 
            this.phoneNumber_TB.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.phoneNumber_TB.BackColor = System.Drawing.Color.DodgerBlue;
            this.phoneNumber_TB.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.phoneNumber_TB.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.phoneNumber_TB.Location = new System.Drawing.Point(93, 96);
            this.phoneNumber_TB.Multiline = true;
            this.phoneNumber_TB.Name = "phoneNumber_TB";
            this.phoneNumber_TB.Size = new System.Drawing.Size(113, 16);
            this.phoneNumber_TB.TabIndex = 21;
            // 
            // sendCode_BTN
            // 
            this.sendCode_BTN.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.sendCode_BTN.Font = new System.Drawing.Font("Segoe UI", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.sendCode_BTN.Location = new System.Drawing.Point(221, 114);
            this.sendCode_BTN.Name = "sendCode_BTN";
            this.sendCode_BTN.Size = new System.Drawing.Size(46, 19);
            this.sendCode_BTN.TabIndex = 26;
            this.sendCode_BTN.Text = "OK";
            this.sendCode_BTN.UseVisualStyleBackColor = true;
            this.sendCode_BTN.Click += new System.EventHandler(this.sendCode_BTN_Click);
            // 
            // apiHash_Label
            // 
            this.apiHash_Label.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.apiHash_Label.BackColor = System.Drawing.Color.Cornsilk;
            this.apiHash_Label.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.apiHash_Label.ForeColor = System.Drawing.SystemColors.ControlText;
            this.apiHash_Label.Location = new System.Drawing.Point(0, 21);
            this.apiHash_Label.Name = "apiHash_Label";
            this.apiHash_Label.Size = new System.Drawing.Size(87, 16);
            this.apiHash_Label.TabIndex = 30;
            this.apiHash_Label.Text = "App api_hash:";
            this.apiHash_Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // apiID_Label
            // 
            this.apiID_Label.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.apiID_Label.BackColor = System.Drawing.Color.Cornsilk;
            this.apiID_Label.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.apiID_Label.ForeColor = System.Drawing.SystemColors.ControlText;
            this.apiID_Label.Location = new System.Drawing.Point(0, 0);
            this.apiID_Label.Name = "apiID_Label";
            this.apiID_Label.Size = new System.Drawing.Size(76, 16);
            this.apiID_Label.TabIndex = 29;
            this.apiID_Label.Text = "App api_id:";
            this.apiID_Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // apiHash_TB
            // 
            this.apiHash_TB.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.apiHash_TB.BackColor = System.Drawing.Color.DodgerBlue;
            this.apiHash_TB.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.apiHash_TB.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.apiHash_TB.Location = new System.Drawing.Point(93, 21);
            this.apiHash_TB.Multiline = true;
            this.apiHash_TB.Name = "apiHash_TB";
            this.apiHash_TB.Size = new System.Drawing.Size(113, 16);
            this.apiHash_TB.TabIndex = 28;
            // 
            // apiID_TB
            // 
            this.apiID_TB.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.apiID_TB.BackColor = System.Drawing.Color.DodgerBlue;
            this.apiID_TB.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.apiID_TB.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.apiID_TB.Location = new System.Drawing.Point(93, 0);
            this.apiID_TB.Multiline = true;
            this.apiID_TB.Name = "apiID_TB";
            this.apiID_TB.Size = new System.Drawing.Size(113, 16);
            this.apiID_TB.TabIndex = 27;
            // 
            // configurate_BTN
            // 
            this.configurate_BTN.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.configurate_BTN.Font = new System.Drawing.Font("Segoe UI", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.configurate_BTN.Location = new System.Drawing.Point(212, 12);
            this.configurate_BTN.Name = "configurate_BTN";
            this.configurate_BTN.Size = new System.Drawing.Size(68, 25);
            this.configurate_BTN.TabIndex = 31;
            this.configurate_BTN.Text = "Configurate";
            this.configurate_BTN.UseVisualStyleBackColor = true;
            this.configurate_BTN.Click += new System.EventHandler(this.configurate_BTN_Click);
            // 
            // ConnectionToTelegram
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(279, 135);
            this.Controls.Add(this.configurate_BTN);
            this.Controls.Add(this.apiHash_Label);
            this.Controls.Add(this.apiID_Label);
            this.Controls.Add(this.apiHash_TB);
            this.Controls.Add(this.apiID_TB);
            this.Controls.Add(this.sendCode_BTN);
            this.Controls.Add(this.connect_BTN);
            this.Controls.Add(this.apiSecret_Label);
            this.Controls.Add(this.apiKey_Label);
            this.Controls.Add(this.codeFromTelegram_TB);
            this.Controls.Add(this.phoneNumber_TB);
            this.Name = "ConnectionToTelegram";
            this.Text = "OK";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button connect_BTN;
        private System.Windows.Forms.Label apiSecret_Label;
        private System.Windows.Forms.Label apiKey_Label;
        private System.Windows.Forms.TextBox codeFromTelegram_TB;
        private System.Windows.Forms.TextBox phoneNumber_TB;
        private System.Windows.Forms.Button sendCode_BTN;
        private System.Windows.Forms.Label apiHash_Label;
        private System.Windows.Forms.Label apiID_Label;
        private System.Windows.Forms.TextBox apiHash_TB;
        private System.Windows.Forms.TextBox apiID_TB;
        private System.Windows.Forms.Button configurate_BTN;
    }
}