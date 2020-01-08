using System;

namespace T5
{
    class Program
    {
        static void Main(string[] args)
        {
            int seconds = 0, minutes = 0, hours = 0;
            Console.WriteLine("Insert any amount of seconds (full seconds) be dear. >");
            seconds = int.Parse(Console.ReadLine());
            if (seconds > 60)
            {
                minutes = seconds / 60;
                seconds = seconds - 60 * minutes;
                if (minutes > 60)
                {
                    hours = minutes / 60;
                    minutes = minutes - 60 * hours;
                }
            }
            Console.WriteLine("Your given amount of seconds can be divided into " + hours + " hours, " + minutes + " minutes and " +seconds+ " seconds");
            Console.ReadLine();
        }
    }
}
