using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T2
{
    class Boat : Vehicle
    {
        public string BoatType { get; set; }
        public int SeatCount { get; set; }
        public Boat()
        {

        }
        public Boat(string name, string model, int modelyear, string color, string boattype, int seats)
            : base(name, model, modelyear, color)
        {
            BoatType = boattype;
            SeatCount = seats;
        }
        public override string ToString()
        {
            return base.ToString() + " Boat type: " + BoatType + " Seat count: " + SeatCount;
        }
    }
}
