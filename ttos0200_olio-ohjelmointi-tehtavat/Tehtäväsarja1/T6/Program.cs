using System;

namespace T6
{
    class Program
    {
        const double USAGE = 7.02 / 100;
        const double PRICE = 1.595;
        static void Main(string[] args)
        {
            Console.WriteLine("How long a distance are you expecting to drive with this car (in kilometers of course)? >");
            double distance = double.Parse(Console.ReadLine());
            double gasoline = USAGE * distance;
            double bill = gasoline * PRICE ;
            Console.WriteLine("Alright. In a journey that long, you'll be  consuming "+ Math.Round(gasoline, 2)+" liters of gas, costing about " + Math.Round(bill, 2) + " Euros.\nHappy Travels!!");
            Console.ReadLine();
        }
    }
}
