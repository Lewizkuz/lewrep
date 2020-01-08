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
            Dice dice = new Dice();
            Console.Write("How many times do you want to throw the dice?");
            int input = int.Parse(Console.ReadLine());
            List<int> values = new List<int>();
            int[] counts = new int[6];
            int tmp = 0;
            for (int i = 0; i < input; i++)
            {
                tmp = dice.Throw();
                values.Add(tmp);
                counts[tmp-1]++;
            }
            Console.WriteLine("Dice was thrown {0} times, average is {1}", values.Count(), values.Average());
            values.Sort();

            for(int i = 0; i < counts.Count(); i++ )
            {
                Console.WriteLine("Count of {0} was {1}", i + 1, counts[i]);
            }
        }
    }
}
