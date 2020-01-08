using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T4
{
    class Program
    {
        static void Main(string[] args)
        {
            int kierrokset = 10;
            int points = 0;
            int[] grade = new int[6];
            for (int i = 0; i < kierrokset; i++)
            {
                Console.WriteLine("Give points (0-5)>");
                points = int.Parse(Console.ReadLine());
                switch (points)
                {
                    case 0: grade[0]++; break;
                    case 1: grade[1]++; break;
                    case 2: grade[2]++;break;
                    case 3: grade[3]++; break;
                    case 4: grade[4]++; break;
                    case 5: grade[5]++; break;
                    default: break;
                }
            }
            
            Console.WriteLine("Grades in order: ");
            for (int i = 0; i < grade.Length; i++)
            {
                Console.Write(i.ToString() + ": ");
                for (int j = 0; j < grade[i]; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

            Console.ReadLine();
        }
    }
}
