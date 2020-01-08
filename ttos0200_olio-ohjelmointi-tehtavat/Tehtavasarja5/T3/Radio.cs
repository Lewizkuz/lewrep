using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T3
{
    class Radio
    {
        private bool IsOn { get; set; }
        private int VolumeReal { get; set; }
        private double FrequencyReal { get; set; }
        public double Frequency
        {
            get
            {
                return FrequencyReal;
            }
            set
            {
                if (value < 2000.0)
                {
                    Console.WriteLine("Invalid Input. Setting to MINVALUE");
                    FrequencyReal = 2000.0;
                }
                else if (value > 26000.0)
                {
                    Console.WriteLine("Invalid Input. Setting to MINVALUE ");
                    FrequencyReal = 26000.0;
                }
                else
                {
                    FrequencyReal = value;
                }
                Console.WriteLine("Frequency set to: "+ FrequencyReal);
            }
        }
        public Radio()
        {
            IsOn = false;
            VolumeReal = 1;
        }
        public void PowerSwitch()
        {
            if (IsOn == true)
            {
                IsOn = false;
                Console.WriteLine("Radio has been turned off");
            }
            else
            {
                IsOn = true;
                Console.WriteLine("Radio has been turned on");
            }
        }
        public void VolumeUp()
        {
            if (VolumeReal < 10)
            {
                VolumeReal++;
                Console.WriteLine("Volume set to: " + VolumeReal);
            }
            else
            {
                Console.WriteLine("Volume is at max: 9");
            }
        }
        public void VolumeDown()
        {
            if (VolumeReal > 0)
            {
                VolumeReal--;
                Console.WriteLine("Volume set to: " + VolumeReal);
            }
            else
            {
                Console.WriteLine("Volume is at minimum value: 9");
            }
        }
    }
}
