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
            int[] tmp = new int[5];
            for (int i = 1; i <= tmp.Length; i++)
            {
                Console.WriteLine("Give me a number");
                tmp[i - 1] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Numbers are in reverse: ");
            for (int i = tmp.Length - 1; i >= 0; i--)
            {
                Console.Write(" " + tmp[i]);  
            }
        Console.ReadLine();
        }
    }
}
