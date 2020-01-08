using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T2
{
    class Elevator
    {
        private readonly int Maxfloor = 5;
        private readonly int Minfloor = 1;
        private int floor { get; set; }
        public int Floor
        { 
            get
            {
                return floor;
            }
            set
            {
                if (value <= Maxfloor && value >= Minfloor) floor = value;
                else if (value > Maxfloor)
                {
                    Console.WriteLine("Input out of range. setting to Maxvalue = "+ Maxfloor);
                    floor = Maxfloor;
                }
                else
                {
                    Console.WriteLine("Input out of range. setting to Minvalue = " + Minfloor);
                    floor = Minfloor;
                }
            }
        }
        public Elevator()
        {
            floor = 1;
        }
    }
}
