using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T2
{
    class Vehicle
    {
        public string Name { get; set; }
        public string Model { get; set; }
        public int ModelYear { get; set; }
        public string Colour { get; set; }

        public Vehicle()
        {

        }
        public Vehicle(string name, string model, int modelyear, string color)
        {
            Name = name;
            Model = model;
            ModelYear = modelyear;
            Colour = color;
        }
        public override string ToString()
        {
            return "Name: " + Name + " Model: " + Model + " " + ModelYear + " Colour: " + Colour;
        }
    }
}
