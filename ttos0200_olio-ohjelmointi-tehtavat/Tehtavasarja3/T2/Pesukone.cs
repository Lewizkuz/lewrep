using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T2
{
    class Pesukone
    {
        /// <summary>
        /// Determines wether the machine is on. true = on 
        /// </summary>
        bool Ison { get; set; }

        /// <summary>
        /// Determines if machine is using water at the moment. true = yes
        /// </summary>
        bool Water { get; set; }

        /// <summary>
        /// Determines if machine is using detergent at the moment. true = yes
        /// </summary>
        bool Detergent { get; set; }

        /// <summary>
        /// Model of the machine
        /// </summary>
        string Model { get; set; }
        double Temperature { get; set; }
        string Program { get; set; }

        /// <summary>
        /// Alustaa pesukoneen.
        /// </summary>
        public Pesukone()
        {
            Program = "Awaiting program";
            Ison = false;
            Temperature = 0;
        }
        /// <summary>
        /// Alustaa pesukoneen
        /// </summary>
        /// <param name="Modelinput">Pesukoneen malli</param>
        public Pesukone(string Modelinput)
        {
            Model = Modelinput;
            Program = "Awaiting program";
            Ison = false;
            Temperature = 0;
        }
        /// <summary>
        /// Arkipesuohjelma 30 asteen lämpötilassa.
        /// </summary>
        public void Perusohjelma()
        {
            Ison = true;
            Water = true;
            Detergent = true;
            Temperature = 30;
            Program = "Basic program";
            Console.WriteLine("Arkipesuohjelma käynnistetty.");
        }
        /// <summary>
        /// Pesuohjelma tekokuituvaatteille 40 asteen lämpötilassa.
        /// </summary>
        public void Tekokuituohjelma()
        {
            Ison = true;
            Water = true;
            Detergent = true;
            Temperature = 40;
            Program = "Program for artificial fabric";
            Console.WriteLine("Ohjelma tummille vaatteille aloitettu.");
        }
        /// <summary>
        /// Pesuohjelma ilman pesuainetta ja lämpötila 30 astetta.
        /// </summary>
        public void Vesipesu()
        {
            Ison = true;
            Water = true;
            Detergent = false;
            Temperature = 30;
            Program = "Wash without detergent";
            Console.WriteLine(" Huuhtelu aloitettu.");
        }
        /// <summary>
        /// Ohjelma ilman vettä tai pesuainetta.
        /// </summary>
        public void Linkous()
        {
            Ison = true;
            Water = false;
            Detergent = false;
            Temperature = 30;
            Program = "Program with no water";
            Console.WriteLine("Linkous aloitettu");
        }
        /// <summary>
        /// Tulosta koneen nykyinen tila : malli, virta, vesi, pesuaine, lämpötila ja ohjelma
        /// </summary>
            public void Printinfo()
        {
            Console.WriteLine("Info of your machine:");
            Console.WriteLine("- Model of machine: " + Model);
            Console.WriteLine("- IsOn: " + Ison);
            if (Ison == true)
            {
                Console.WriteLine("- Using water: " + Water);
                Console.WriteLine("- Using detergent: " + Detergent);
                Console.WriteLine("- Temperature (in 'C): " + Temperature);
            }
            Console.WriteLine("- Current program: " + Program);
        }
    }
}
