using System;

namespace T7
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Is your inserted totally random year a leap year? I will tell you! (Only full years please)>");
            int years = int.Parse(Console.ReadLine());
            if (years % 4 == 0 || years % 400 == 0) Console.WriteLine("Your inserted year was indeed a leap year. Yippy Koo Kalay!");
            else Console.WriteLine("Your inserted year was not a leap year. Good to know!");
            Console.ReadLine();
        }
    }
}
