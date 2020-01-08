using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T1
{
    class Kiuas
    {
        //properties
        public bool Onoff{ get; set;}
        public double Temperature { get; set;}
        public double Humidity { get; set;}

        //  constructors
        public Kiuas (double temp = 0, double humid = 0)
        {
            temp = Temperature;
            humid = Humidity;
        }

        //  methods
        public void TurnOn()
        {
            Onoff = true;
        }
        public void TurnOff()
        {
            Onoff = false;
        }
        public void SetHeat(double tmp)
        {
            Temperature = tmp;
        }
        public void SetHumid(double humid)
        {
            Humidity = humid;
        }
        public void ShowInfo()
        {
            Console.WriteLine("Information regarding this kiuas:");
            Console.WriteLine("- Is ON: " + Onoff);
            Console.WriteLine("- Heat (in Celcius): " + Temperature + " 'C" );
            Console.WriteLine("- Humidity: "+ Humidity + " %");
        }

    }
}
