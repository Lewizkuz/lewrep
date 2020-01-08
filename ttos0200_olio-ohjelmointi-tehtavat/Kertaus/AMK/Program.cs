using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AMK
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Oppilas> oppilaat = new List<Oppilas>();
            oppilaat.Add(new Oppilas("Make Mainio", "A0001"));
            oppilaat.Add(new Oppilas("Kirsi Kernel", "A0002"));
            oppilaat.Add(new Oppilas("Timo Tiainen", "A0003"));
            foreach (Oppilas oppilas in oppilaat)
            {
                Console.WriteLine(oppilas.NäytäTiedot());
            }
            List<Opettaja> opettajat = new List<Opettaja>();
            opettajat.Add(new Opettaja("Ville Viisas", "ViVii"));
            opettajat.Add(new Opettaja("Matti Näsä", "MaNäs"));
            opettajat.Add(new Opettaja("Jarmo Jäpälä", "JaJäp"));
            foreach (Opettaja opettaja in opettajat)
            {
                Console.WriteLine(opettaja.NäytäTiedot());
            }
        }
    }
}
