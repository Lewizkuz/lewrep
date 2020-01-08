using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T3
{
    class Fisherman
    {
        public string Name { get; set; }
        public string PhoneNum { get; set; }
        public List<Fish> Caught { get; set; }

        public Fisherman(string name, string phone)
        {
            Console.WriteLine("A new fisherman has been added to Fish-register:\n");
            Name = name;
            PhoneNum = phone;
            Console.WriteLine(" - Fisherman {0} Phone: {1}\n", Name, PhoneNum);

            Caught = new List<Fish>();
        }
        public void Catch(Fish fish)
        {
            Console.WriteLine("Fisher {0} has caught a new fish\n", Name);
            Caught.Add(fish);
            fish.PrintInfo();
        }
        public void PrintCaught()
        {
            Console.WriteLine("Fisherman {0} has caught following fish:\n");
            foreach (Fish fish in Caught)
            {
                fish.PrintInfo();
            }
        }
    }
}
