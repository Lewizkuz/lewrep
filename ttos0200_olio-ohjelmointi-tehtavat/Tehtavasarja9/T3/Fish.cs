using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T3
{
    class Fish
    {
        public string Species { get; set; }
        public int Size { get; set; }
        public double Weight { get; set; }
        public string Place { get; set; }
        public string Habitat { get; set; }

        public Fish(string species, int size, double weight, string place, string habitat)
        {
            Species = species;
            Size = size;
            Weight = weight;
            Place = place;
            Habitat = habitat;
        }
        public void PrintInfo()
        {
            Console.WriteLine(" - specie: {0} {1} mm {2} kg", Species, Size, Weight);
            Console.WriteLine(" - place: {0}\n - location: {1}\n", Place, Habitat);
        }
    }
}
