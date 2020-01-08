using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T4
{
    class Program
    {
        static void Main(string[] args)
        {
            //  Luodaan vehicle: bike
            Console.WriteLine("Creating a bike:");
            Vehicle bike = new Vehicle();

            //  Näytetään tostring funktio
            Console.WriteLine("ToString-funktio:");
            string mjono = bike.ToString();
            Console.WriteLine(mjono);
            
            //  Asetetaan nopeusarvo ja tulostetaan:
            bike.Speed = 25;
            mjono = bike.ToString();

            //  Lopuksi Printdata:
            Console.WriteLine("Printdata:");
            bike.PrintData();
        }
    }
}
