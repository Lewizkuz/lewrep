using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T1
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("Give a number (0 to exit) > ");
                string input = Console.ReadLine();
                    int number = int.Parse(input);
                
                Console.Write("Number you inserted was ");
                switch (number)
                {
                    case 0: return;
                    case 1: Console.Write("one"); break;
                    case 2: Console.Write("two."); break;
                    case 3: Console.Write("three."); break;
                    default: Console.Write("something else."); break;
                }
                Console.WriteLine("");
            }
        }
    }
}
