using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T5
{
    class Opiskelija
    {
        public string nimi { get; set; }
        public int ika { get; set; }
        public string sukup { get; set; }
        public string ala { get; set; }
        public bool auto { get; set; }
        public double saldo { get; set; }
        public float promille { get; set; }

        public Opiskelija(string name, bool onkomies)
        {
            nimi = name;
            ika = 19;
            if (onkomies) sukup = "mies";
            else sukup = "nainen";
            ala = "elämä";
            auto = false;
            saldo = 50.0;
            promille = 0;
        }
        public void Tulostatiedot()
        {
            Console.WriteLine("Opiskelijan " + nimi + " tiedot:\n- sukupuoli: " + sukup + "\n- ala: " + ala + "\n- omistaa auton " + auto + "\n- Tilin saldo " + saldo + "\n- promille: " + promille);
        }
        public void Torstai()
        {
            saldo = saldo - 50;
            promille = promille + 4;
        }

    }
}
