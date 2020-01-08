using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T3
{
    class Amp
    {
        private const int MAXVALUE = 100;
        private const int MINVALUE = 0;
        private int Volumereal { get; set; }
        public int Volume
        {
            get
            {
                return Volumereal;
            }
            set
            {
                if (value <= MAXVALUE && value >= MINVALUE) Volumereal = value;
                else if (value > MAXVALUE)
                {
                    Console.WriteLine("Inserted value out of range. Setting to Maxvalue: " + MAXVALUE);
                    Volumereal = MAXVALUE;
                }
                else if (value < MINVALUE)
                {
                    Console.WriteLine("Inserted value out of range. Setting to Minvalue: " + MINVALUE);
                    Volumereal = MINVALUE;
                }
                else
                {
                    Console.WriteLine("Invalid input. Volume remains unchanged.");
                }
            }
        }
        public void Setvolume()
        {
            Console.WriteLine("Set Volume of your amplifier (0 - 100):");

            string textinput = Console.ReadLine();
            if (int.TryParse(textinput, out  int input))
            {
                Volume = int.Parse(textinput);
            }
        }
}
}
