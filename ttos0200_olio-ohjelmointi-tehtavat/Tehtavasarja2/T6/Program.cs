using System;

namespace t6
{
    class Program
    {
        static void Main(string[] args)
        {
            int guess = 0, input = 0, goalnum = 0;
            Random number = new Random();
            goalnum = number.Next(0, 100);

            while (input != goalnum)
            {
                Console.WriteLine("Guess a number: ");
                input = int.Parse(Console.ReadLine());
                if (input > goalnum)
                {
                    Console.WriteLine("Your number is too big.");
                }
                else if (input < goalnum)
                {
                    Console.WriteLine("Your number is too small");
                }
                else
                {
                    Console.WriteLine("");
                }
                guess = guess + 1;
            }
            Console.WriteLine("Great! it takes " + guess + " guesses.");
            Console.ReadLine();
        }
    }
}
