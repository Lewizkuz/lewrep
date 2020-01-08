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
            Console.Write("Give me your score. (Max = 12) > ");
            int score = int.Parse(Console.ReadLine());
            Console.WriteLine("");
            Console.Write("Your grade is:  ");
            switch (score)
            {
                case 0:
                case 1: Console.WriteLine("0"); break;
                case 2:
                case 3: Console.WriteLine("0"); break;
                case 4:
                case 5: Console.WriteLine("1"); break;
                case 6:
                case 7: Console.WriteLine("1"); break;
                case 8:
                case 9:  Console.WriteLine("2"); break;
                case 10:
                case 11:
                case 12: Console.WriteLine("2"); break;
                default: Console.WriteLine("unknown value"); break;
            }
            Console.ReadLine();
        }
    }
}
