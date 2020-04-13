namespace MobilePhoneWinForm
{
    partial class MobileWinForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.OutputText = new System.Windows.Forms.TextBox();
            this.IphoneHeadset = new System.Windows.Forms.RadioButton();
            this.SamsungHeadset = new System.Windows.Forms.RadioButton();
            this.WirelessCharger = new System.Windows.Forms.RadioButton();
            this.USBCharger = new System.Windows.Forms.RadioButton();
            this.SelectAudio = new System.Windows.Forms.Button();
            this.SelectCharger = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.SelectAudio);
            this.groupBox1.Controls.Add(this.SamsungHeadset);
            this.groupBox1.Controls.Add(this.IphoneHeadset);
            this.groupBox1.Location = new System.Drawing.Point(7, 9);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(125, 130);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "AudioComponents";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.SelectCharger);
            this.groupBox2.Controls.Add(this.USBCharger);
            this.groupBox2.Controls.Add(this.WirelessCharger);
            this.groupBox2.Location = new System.Drawing.Point(144, 9);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(128, 130);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "ChargeComponents";
            // 
            // OutputText
            // 
            this.OutputText.Location = new System.Drawing.Point(7, 145);
            this.OutputText.Multiline = true;
            this.OutputText.Name = "OutputText";
            this.OutputText.Size = new System.Drawing.Size(265, 104);
            this.OutputText.TabIndex = 2;
            // 
            // IphoneHeadset
            // 
            this.IphoneHeadset.AutoSize = true;
            this.IphoneHeadset.Location = new System.Drawing.Point(8, 25);
            this.IphoneHeadset.Name = "IphoneHeadset";
            this.IphoneHeadset.Size = new System.Drawing.Size(58, 17);
            this.IphoneHeadset.TabIndex = 0;
            this.IphoneHeadset.TabStop = true;
            this.IphoneHeadset.Text = "Iphone";
            this.IphoneHeadset.UseVisualStyleBackColor = true;
            // 
            // SamsungHeadset
            // 
            this.SamsungHeadset.AutoSize = true;
            this.SamsungHeadset.Location = new System.Drawing.Point(8, 50);
            this.SamsungHeadset.Name = "SamsungHeadset";
            this.SamsungHeadset.Size = new System.Drawing.Size(69, 17);
            this.SamsungHeadset.TabIndex = 1;
            this.SamsungHeadset.TabStop = true;
            this.SamsungHeadset.Text = "Samsung";
            this.SamsungHeadset.UseVisualStyleBackColor = true;
            // 
            // WirelessCharger
            // 
            this.WirelessCharger.AutoSize = true;
            this.WirelessCharger.Location = new System.Drawing.Point(12, 25);
            this.WirelessCharger.Name = "WirelessCharger";
            this.WirelessCharger.Size = new System.Drawing.Size(104, 17);
            this.WirelessCharger.TabIndex = 0;
            this.WirelessCharger.TabStop = true;
            this.WirelessCharger.Text = "Wireless charger";
            this.WirelessCharger.UseVisualStyleBackColor = true;
            // 
            // USBCharger
            // 
            this.USBCharger.AutoSize = true;
            this.USBCharger.Location = new System.Drawing.Point(12, 50);
            this.USBCharger.Name = "USBCharger";
            this.USBCharger.Size = new System.Drawing.Size(86, 17);
            this.USBCharger.TabIndex = 1;
            this.USBCharger.TabStop = true;
            this.USBCharger.Text = "USB charger";
            this.USBCharger.UseVisualStyleBackColor = true;
            // 
            // SelectAudio
            // 
            this.SelectAudio.Location = new System.Drawing.Point(67, 97);
            this.SelectAudio.Name = "SelectAudio";
            this.SelectAudio.Size = new System.Drawing.Size(52, 27);
            this.SelectAudio.TabIndex = 3;
            this.SelectAudio.Text = "Select";
            this.SelectAudio.UseVisualStyleBackColor = true;
            // 
            // SelectCharger
            // 
            this.SelectCharger.Location = new System.Drawing.Point(66, 97);
            this.SelectCharger.Name = "SelectCharger";
            this.SelectCharger.Size = new System.Drawing.Size(56, 27);
            this.SelectCharger.TabIndex = 2;
            this.SelectCharger.Text = "Select";
            this.SelectCharger.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.OutputText);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton SamsungHeadset;
        private System.Windows.Forms.RadioButton IphoneHeadset;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton USBCharger;
        private System.Windows.Forms.RadioButton WirelessCharger;
        private System.Windows.Forms.TextBox OutputText;
        private System.Windows.Forms.Button SelectAudio;
        private System.Windows.Forms.Button SelectCharger;
    }
}

