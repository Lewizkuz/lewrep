using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T2
{
    class Bike : Vehicle
    {
        public bool GearWheels { get; set; }
        public string GearName { get; set; }
        public Bike()
        {

        }
        public Bike(string name, string model, int modelyear, string color, bool gearwheels, string gearname)
            : base(name, model, modelyear, color)
        {
            GearWheels = gearwheels;
            GearName = gearname;
        }
        public override string ToString()
        {
            return base.ToString() + " Has gearwheels: " + GearWheels + " Name of Gear: " + GearName;
        }
    }
}
