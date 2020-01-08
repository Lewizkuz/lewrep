using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T1
{
    class Dice
    {
        private int MAXVALUE = 6;
        private int MINVALUE = 1;
        private readonly Random Random = new Random();
        private int Numreal { get; set; }
        public int Number
        {
            get
            {
                return Numreal;
            }
            set
            {
                if (value > MAXVALUE)
                {
                    Console.WriteLine("Value out of range setting to MAXVALUE");
                    Numreal = MAXVALUE;
                }
                else if (value < MINVALUE)
                {
                    Console.WriteLine("Value out of range setting to MINVALUE");
                    Numreal = MINVALUE;
                }
                else
                {
                    Numreal = value;
                }
            }
        }
        public Dice()
        {
        }
        public int Throw()
        {
            return Random.Next(MINVALUE, MAXVALUE + 1);
        }
        
    }
}
