using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Anna puun korkeus>");
            int input = int.Parse(Console.ReadLine());
            int juuri = 2;
            for (int cycle = 1; cycle < input; cycle++)
            {
                for (int i = input - cycle; i > 0; i--)
                {
                    Console.Write(" ");
                }
                    Console.Write("*");
                for (int i = 1; i < cycle; i++)
                {
                    Console.Write("**");
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
