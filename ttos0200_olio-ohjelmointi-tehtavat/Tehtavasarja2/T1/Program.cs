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
            Console.WriteLine("Kerro kuinka suuri pyramidi rakennetaan >");
            int s = int.Parse(Console.ReadLine());
            for (int i = 1; i <= s; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
