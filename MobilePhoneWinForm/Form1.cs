using MobilePhone.AudioEntity;
using MobilePhone.ChargerEntity;
using MobilePhone.Interfaces;
using MobilePhone.MobilePhoneEntity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MobilePhoneWinForm
{
    public partial class MobileWinForm : Form
    {
        private IOutput Output;
        private readonly Mobile MobilePhone = new SimcorpMobile("Samsung");
        public MobileWinForm()
        {
            InitializeComponent();
        }
        private void MainFormLoad(object sender, EventArgs e)
        {
            Output = new TextBoxOutput(this.OutputText);
        }
        private void PlaybackApplyButtonOnClick(object sender, EventArgs e)
        {
            if (this.IphoneHeadset.Checked)
            {
                MobilePhone.PlayBackComponent = new IphoneHeadset(Output);
            }
            else if (this.SamsungHeadset.Checked)
            {
                MobilePhone.PlayBackComponent = new SamsungHeadset(Output);
            }
            Output.WriteLine("Playback component has been set to the mobile. Play sound in mobile:");
            MobilePhone.Play("music");
            
        }

        private void ChargerApplyButtonOnClick(object sender, EventArgs e)
        {
            if (this.USBCharger.Checked)
            {
                MobilePhone.ChargerDevice = new USBCharger(Output);
            }
            else if (this.WirelessCharger.Checked)
            {
                MobilePhone.ChargerDevice = new WirelessCharge(Output);
            }

            Output.WriteLine("Charger device has been set to the mobile. Charging the mobile:");
            MobilePhone.Charge();
            
        }

        private void CleanButtonOnClick(object sender, EventArgs e)
        {
            ((TextBoxOutput)Output).Clear();
        }

    }
}
