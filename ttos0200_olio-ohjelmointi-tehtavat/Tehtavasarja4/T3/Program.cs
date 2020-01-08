using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T3
{
    class Program
    {
        static void Main(string[] args)
        {
            Amp Amplifier = new Amp();
            int input = 1;
            int quit = 0;
            do
            {
                Amplifier.Setvolume();
                Console.WriteLine("Volume of your Amplifier: "+ Amplifier.Volume);
                Console.WriteLine("Wanna quit?: 1/0 >");
                string tmp = Console.ReadLine();
                if (int.TryParse(tmp,out input))
                {
                    quit = int.Parse(tmp);
                }
                
            } while (quit != 1);
        }
    }
}
