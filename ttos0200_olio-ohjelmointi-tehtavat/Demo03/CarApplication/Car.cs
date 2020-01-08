using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarApplication
{
    class Car
    {
        //properties
        public string Model { get; set; }
        public string Color { get; set; }
        public double Engine { get; set; }
        public bool FuzzyDices { get; set; }
        public int Speed { get; set; }

        //  constructors
        public Car()
        {

        }
        public Car( string model) //    model = "Audi"
        {
            Model = model;
        }
        //  Methods

        public void Accelerate()
        {
            Speed += 10;
        }
        public void Brake()
        {
            Speed -= 10;
        }
        public void PrintData()
        {
            Console.WriteLine("Car data:");
            Console.WriteLine("- model: " + Model);
            Console.WriteLine("- color: " + Color);
            Console.WriteLine("- engine: " + Engine);
            Console.WriteLine("- speed: " + Speed);
            Console.WriteLine("- fuzzydices: "+ FuzzyDices);
        }
    }
}
