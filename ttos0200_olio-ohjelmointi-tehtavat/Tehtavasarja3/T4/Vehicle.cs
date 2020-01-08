using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T4
{
    class Vehicle
    {
        /// <summary>
        /// Vehicle luokan nopeusarvo
        /// </summary>
        public int Speed { get; set; }
        /// <summary>
        /// Vehicle luokan renkaiden lukumäärä
        /// </summary>
        public int Tyres { get; set; }
        /// <summary>
        /// Vehicle luokan oletus-constructor: Speed = 0, Tyres = 2
        /// </summary>
        public Vehicle()
        {
            Speed = 0;
            Tyres = 2;
        }
        /// <summary>
        /// Vehicle luokan constructor: Speed = 0 
        /// </summary>
        /// <param name="tyres">Luodun vehicle-luokan renkaiden lukumäärä</param>
        public Vehicle(int tyres)
        {
            Speed = 0;
            Tyres = tyres;
        }
        /// <summary>
        /// Vehicle luokan constructor 
        /// </summary>
        /// <param name="speed">Luodun vehicle-luokan nopeus</param>
        /// <param name="tyres">Luodun Vehicle-luokan renkaiden lukumäärä</param>
        public Vehicle(int speed, int tyres)
        {
            Speed = speed;
            Tyres = tyres;
        }
        /// <summary>
        /// Tulostaa vehicle-luokan tiedot konsoliin 
        /// </summary>
        public void PrintData()
        {
            Console.WriteLine("Printing info of your car:\n- Speed:" + Speed + "\n- Number of tyres: " + Tyres);
        }
        /// <summary>
        /// Palauttaa vehicle-luokan tiedot merkkijonona
        /// </summary>
        /// <returns>string</returns>
        public override string ToString()
        {
            string output = "Speed: " + Speed + " Tyres: " + Tyres;
            return output;
        }
    }
}
