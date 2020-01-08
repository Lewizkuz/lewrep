using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T1
{
    class Program
    {
        static void Main(string[] args)
        {
            Kiuas harvia = new Kiuas();
            harvia.TurnOn();
            harvia.SetHeat(80.0);
            harvia.SetHumid(20);

            harvia.ShowInfo();
        }
    }
}
