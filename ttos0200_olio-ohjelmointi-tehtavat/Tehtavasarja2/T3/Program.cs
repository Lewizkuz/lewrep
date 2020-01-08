using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] luvut = new int[5];
            for (int i = 0; i < luvut.Length; i++)
            {
                Console.WriteLine("Give points >");
                luvut[i] = int.Parse(Console.ReadLine());
            }
            int total = luvut.Sum() - luvut.Max() - luvut.Min();
            Console.WriteLine("Total points are " + total);
        }
    }
}
