 using System;

namespace T3
{
    class Program
    {
        static void Main(string[] args)
        {
            double n1, n2, n3;
            Console.WriteLine("Insert three numbers, kindly please. >");
            n1 = double.Parse(Console.ReadLine());
            n2 = double.Parse(Console.ReadLine());
            n3 = double.Parse(Console.ReadLine());
            double sum = n1 + n2 + n3;
            double average = sum / 3.0;
            Console.Write("The Average of your numbers is " + average + " and the sum is " + sum);
            Console.ReadLine();
        }
    }
}
