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
            Dictionary<string, Opiskelija> opiskelijat = new Dictionary<string, Opiskelija>();

            Opiskelija opiskelija1 = new Opiskelija
            {
                Etunimi = "Masa",
                Sukunimi = "Niemi",
                AsioId = "A0001",
                Ryhma = "TTVS17S2"
            };

            Opiskelija opiskelija2 = new Opiskelija {
                Etunimi = "Matti",
                Sukunimi = "Husso",
                AsioId = "A0002",
                Ryhma = "TTVS17S2"
            };

            Opiskelija opiskelija3 = new Opiskelija
            {
                Etunimi = "Kirsi",
                Sukunimi = "Vuolle",
                AsioId = "A0003",
                Ryhma = "TTVS17S1"
            };
            Opiskelija opiskelija4 = new Opiskelija
            {
                Etunimi = "Teppo",
                Sukunimi = "Testaaja",
                AsioId = "A0004",
                Ryhma = "TTVS17S3"
            };

            opiskelijat.Add(opiskelija1.AsioId, opiskelija1);
            opiskelijat.Add(opiskelija2.AsioId, opiskelija2);
            opiskelijat.Add(opiskelija3.AsioId, opiskelija3);
            opiskelijat.Add(opiskelija4.AsioId, opiskelija4);

            string asioID = "A0003";
            if (opiskelijat.ContainsKey(asioID))
            {
                Console.WriteLine("Opiskelijan tiedot: " + opiskelijat[asioID]);
            }
            else
            {
                Console.WriteLine("Kokoelmasta ei löydy opiskelijaa, jolla on seuraavaa ID:tä: "+ asioID);
            }
            // tulostetaan kokoelman opiskelijat
            Console.WriteLine("Anna uuden lisättävän opiskelijan tiedot");
            Console.WriteLine("Anna asioID: ");
            string ai = Console.ReadLine();
            if (opiskelijat.ContainsKey(ai))
            {
                Console.WriteLine("Asiossa on jo opiskelija tällä ID:llä. Ei listattu ");
            }
            else
            {
                Console.Write("Anna etunimi: ");
                string en = Console.ReadLine();
                Console.Write("Anna sukunimi: ");
                string sn = Console.ReadLine();
                Console.Write("Anna ryhmätunnus: ");
                string ry = Console.ReadLine();
                Opiskelija uusi = new Opiskelija
                {
                    Etunimi = en,
                    Sukunimi = sn,
                    AsioId = ai,
                    Ryhma = ry
                };
                opiskelijat.Add(uusi.AsioId, uusi);
            }
            Console.WriteLine("Kokoelma sisältää seuraavat opiskelijat:");
            foreach (Opiskelija opiskelija in opiskelijat.Values)
            {
                Console.WriteLine(opiskelija);
            }
            Console.Write("Anna opiskelijan tunnus jonka haluat poistaa:");
            string tun = Console.ReadLine();
            if (opiskelijat.ContainsKey(tun))
            {
                opiskelijat.Remove(tun);
            }
            else
            {
                Console.Write("");
            }
            Console.WriteLine("Kokoelma sisältää seuraavat opiskelijat:");
            foreach (Opiskelija opiskelija in opiskelijat.Values)
            {
                Console.WriteLine(opiskelija);
            }
        }
    }
}
