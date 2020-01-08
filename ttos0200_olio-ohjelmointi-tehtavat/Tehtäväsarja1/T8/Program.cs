using System;

namespace T8
{
    class Program
    {
        static void Main(string[] args)
        {
            double n1, n2, n3, suurin;
            Console.WriteLine("Insert three numbers, be dear.");
            n1 = double.Parse(Console.ReadLine());
            n2 = double.Parse(Console.ReadLine());
            n3 = double.Parse(Console.ReadLine());
            if (n1 >= n2 && n1 >= n3) suurin = n1;
            else if (n2 >= n1 && n2 >= n3) suurin = n2;
            else suurin = n3;
            Console.WriteLine("The largest number you inserted was " + suurin);
            Console.ReadLine();
        }
    }
}
