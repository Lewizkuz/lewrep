using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T1
{
    class Vehicle
    {
        public string Name { get; set; }
        public string Model { get; set; }
        public List<Tyre> Renkaat { get; set; }

        public Vehicle()
        {
            Console.WriteLine("Vehicle-element has been added");
            Renkaat = new List<Tyre> { };
        }
        public Vehicle(string name, string model)
        {
            Name = name;
            Model = model;
            Console.WriteLine("Vehicle-element has been added Name: " + Name + " Model: " + Model);
            Renkaat = new List<Tyre> { };
        }
        public void AddTyres(int numtyres, string tyremodel, string tyretype, string tyresize)
        {
            for (int i = 0; i <= numtyres; i++)
            {
                Renkaat.Add(new Tyre(tyremodel, tyretype, tyresize));
                Console.WriteLine("Tyre " + tyremodel +" "+ tyretype + " Has been added");
            }
            Console.WriteLine("\n");
        }
        public void PrintInfo()
        {

            Console.WriteLine("Vehicle Name: " + Name + " Model: " + Model + "\nTyres:");
            foreach (Tyre rengas in Renkaat)
            {
                Console.WriteLine("-Name: " + rengas.Model + " Model: " + rengas.Type + " Tyre-Size: " + rengas.Size);
            }
            Console.WriteLine("\n");

        }
    }
}
