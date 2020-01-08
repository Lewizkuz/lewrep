using System;

namespace T4
{
    class Program
    {
        static void Main(string[] args)
        {
            double age;
            string title = "";
            Console.WriteLine("Insert your age in years, please >");
            age = double.Parse(Console.ReadLine());
            if (age < 18) title = "Child";
            else if (age < 65) title = "Adult";
            else title = "Senior";
            Console.Write("Thus you are classified as " + title + ". Bully for You!");
            Console.ReadLine();
        }
    }
}
