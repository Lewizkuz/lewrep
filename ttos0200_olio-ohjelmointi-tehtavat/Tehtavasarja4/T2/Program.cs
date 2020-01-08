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
            int input = 1;
            Elevator hissi = new Elevator();
            do
            {
                Console.WriteLine("Elevator is in floor: " + hissi.Floor);
                Console.WriteLine("Give a new floor number (1-5) >");
                string parse = Console.ReadLine();
                if (int.TryParse(parse, out input))
                {
                    input = int.Parse(parse);
                    hissi.Floor = input;
                }
                else
                {
                    Console.WriteLine("Wrong input. floor remains unchanged.\n");
                    input = 1;
                }
            } while (input != 0);
        }
    }
}
