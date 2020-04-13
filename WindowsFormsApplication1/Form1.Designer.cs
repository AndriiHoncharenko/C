namespace WindowsFormsApplication1
{
    partial class Form1
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
        private System.Windows.Forms.GroupBox PlayBackGoupBox;      
        private System.Windows.Forms.RadioButton SamsungHeadsetRadioButton;
        private System.Windows.Forms.RadioButton IphoneHeadsetRadioButton;
        private System.Windows.Forms.RadioButton PhoneSpeakerRadioButton;
        private System.Windows.Forms.Button PlaybackApplyButton;

        private System.Windows.Forms.GroupBox ChargerDevicesGroupBox;
        private System.Windows.Forms.RadioButton WirelessChargeRadioButton;
        private System.Windows.Forms.RadioButton USBChargeRadioButton;
        private System.Windows.Forms.Button ChargerApplyButton;

        private System.Windows.Forms.TextBox OutTextBox;
        private System.Windows.Forms.Button CleanButton;
        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(355, 294);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion
    }
}

