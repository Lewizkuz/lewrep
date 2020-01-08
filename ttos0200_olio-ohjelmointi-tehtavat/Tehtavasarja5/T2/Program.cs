using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T2
{
    class Program
    {
        static void Main(string[] args)
        {
            Bike bike = new Bike("Bike", "Jopo", 1001, "yellow", false, "none");
            bike.ToString();
            Boat boat = new Boat("Boat", "Great WHite", 2018, "white", "Cruiser", 4);
            boat.ToString();
            Vehicle vehicle = new Vehicle("Unidentified", "Mysterious", 2000, "Transparent");
            Console.WriteLine(bike.ToString() +"\n"+ boat.ToString() + "\n" + vehicle.ToString());
        }
    }
}
