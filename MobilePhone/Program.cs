﻿using MobilePhone.MobilePhoneEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobilePhone
{
    class Program
    {
        static void Main(string[] args)
        {
            SimcorpMobile mobile = new SimcorpMobile();

            mobile.Battery.Model = "HH100";
            mobile.Battery.Capacity = 3000;

            mobile.Microphone.Name = "Toshiba";
            
            Console.WriteLine(mobile.ToString());
        }
    }
}
