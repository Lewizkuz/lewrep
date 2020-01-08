using System;

namespace T9
{
    class Program
    {
        static void Main(string[] args)
        {
            double sum = 0;
            double input = 1;
            while (input != 0.0)
            {
                Console.WriteLine("Insert as many numbers as you want. (0 to end)");
                input = double.Parse(Console.ReadLine());
                sum = sum + input;
            }
            Console.WriteLine("The sum of all of your inserted numbers was " + sum);
            Console.ReadLine();
        }
    }
}
