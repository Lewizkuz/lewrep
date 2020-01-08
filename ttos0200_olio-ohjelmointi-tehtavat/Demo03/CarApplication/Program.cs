using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            //  create a car instance
            Car datsun = new Car();

            //  use set
            datsun.Color = "Yellow";
            datsun.Model = "Datsun 100A";
            datsun.Engine = 1.0;
            datsun.Speed = 20;
            datsun.FuzzyDices = true;

            //  use get
            Console.WriteLine("Mode1 = " + datsun.Model);

            //  use methods
            datsun.Accelerate();
            datsun.PrintData();

            Car biili = new Car("Audi");
            biili.PrintData();
        }
    }
}
