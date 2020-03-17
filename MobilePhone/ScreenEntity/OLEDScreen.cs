using MobilePhone.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobilePhone.ScreenEntity
{
    class OLEDScreen : ColoredScreen
    {
        public OLEDScreen(float diagonal, int numOfColors) : base(diagonal, numOfColors)
        {

        }
        public override void Show(IScreenImage screenImage)
        {
            Console.WriteLine("Colourful image on OLED screen");
        }
        public override string ToString()
        {
            return "OLED -" + base.ToString();
        }
    }
}
