
namespace BinancePumpRobot
{
    partial class ConnectionToBinance
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
            this.apiSecret_TB = new System.Windows.Forms.TextBox();
            this.apiKey_TB = new System.Windows.Forms.TextBox();
            this.apiKey_Label = new System.Windows.Forms.Label();
            this.apiSecret_Label = new System.Windows.Forms.Label();
            this.connect_BTN = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // apiSecret_TB
            // 
            this.apiSecret_TB.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.apiSecret_TB.BackColor = System.Drawing.Color.DodgerBlue;
            this.apiSecret_TB.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.apiSecret_TB.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.apiSecret_TB.Location = new System.Drawing.Point(72, 42);
            this.apiSecret_TB.Multiline = true;
            this.apiSecret_TB.Name = "apiSecret_TB";
            this.apiSecret_TB.Size = new System.Drawing.Size(164, 24);
            this.apiSecret_TB.TabIndex = 17;
            // 
            // apiKey_TB
            // 
            this.apiKey_TB.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.apiKey_TB.BackColor = System.Drawing.Color.DodgerBlue;
            this.apiKey_TB.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.apiKey_TB.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.apiKey_TB.Location = new System.Drawing.Point(72, 1);
            this.apiKey_TB.Multiline = true;
            this.apiKey_TB.Name = "apiKey_TB";
            this.apiKey_TB.Size = new System.Drawing.Size(164, 24);
            this.apiKey_TB.TabIndex = 16;
            // 
            // apiKey_Label
            // 
            this.apiKey_Label.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.apiKey_Label.BackColor = System.Drawing.Color.Cornsilk;
            this.apiKey_Label.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.apiKey_Label.ForeColor = System.Drawing.SystemColors.ControlText;
            this.apiKey_Label.Location = new System.Drawing.Point(-5, 4);
            this.apiKey_Label.Name = "apiKey_Label";
            this.apiKey_Label.Size = new System.Drawing.Size(76, 16);
            this.apiKey_Label.TabIndex = 18;
            this.apiKey_Label.Text = "API Key:";
            this.apiKey_Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // apiSecret_Label
            // 
            this.apiSecret_Label.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.apiSecret_Label.BackColor = System.Drawing.Color.Cornsilk;
            this.apiSecret_Label.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.apiSecret_Label.ForeColor = System.Drawing.SystemColors.ControlText;
            this.apiSecret_Label.Location = new System.Drawing.Point(-5, 44);
            this.apiSecret_Label.Name = "apiSecret_Label";
            this.apiSecret_Label.Size = new System.Drawing.Size(76, 16);
            this.apiSecret_Label.TabIndex = 19;
            this.apiSecret_Label.Text = "API Secret:";
            this.apiSecret_Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // connect_BTN
            // 
            this.connect_BTN.Font = new System.Drawing.Font("Segoe UI", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.connect_BTN.Location = new System.Drawing.Point(182, 72);
            this.connect_BTN.Name = "connect_BTN";
            this.connect_BTN.Size = new System.Drawing.Size(55, 23);
            this.connect_BTN.TabIndex = 20;
            this.connect_BTN.Text = "Connect";
            this.connect_BTN.UseVisualStyleBackColor = true;
            this.connect_BTN.Click += new System.EventHandler(this.connect_BTN_Click);
            // 
            // ConnectionToBinance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(243, 95);
            this.Controls.Add(this.connect_BTN);
            this.Controls.Add(this.apiSecret_Label);
            this.Controls.Add(this.apiKey_Label);
            this.Controls.Add(this.apiSecret_TB);
            this.Controls.Add(this.apiKey_TB);
            this.Name = "ConnectionToBinance";
            this.Text = "ConnectionToBinance";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox apiSecret_TB;
        private System.Windows.Forms.TextBox apiKey_TB;
        private System.Windows.Forms.Label apiKey_Label;
        private System.Windows.Forms.Label apiSecret_Label;
        private System.Windows.Forms.Button connect_BTN;
    }
}