using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T2
{
    class Program
    {
        static void Main(string[] args)
        {
            Pesukone kone = new Pesukone("Modelname");
            kone.Printinfo();

            kone.Linkous();
            kone.Printinfo();

            kone.Perusohjelma();
            kone.Printinfo();

            kone.Tekokuituohjelma();
            kone.Printinfo();
        }
    }
}
