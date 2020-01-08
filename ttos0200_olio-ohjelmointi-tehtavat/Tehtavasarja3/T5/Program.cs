using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T5
{
    class Program
    {
        static void Main(string[] args)
        {
            Opiskelija maija = new Opiskelija("Maija", false);
            maija.ala = "humanismi";
            maija.Torstai();
            Opiskelija sakke = new Opiskelija("Sakke", true);
            sakke.auto = true;
            Opiskelija juntunen = new Opiskelija("Juntunen", true);
            juntunen.ala = "historia";
            juntunen.ika = 23;

            Opiskelija[] opiskelijataulukko = { maija, sakke, juntunen };
            for(int i= 0; i< opiskelijataulukko.Length; i++)
            {
                opiskelijataulukko[i].Tulostatiedot(); 
            }
        }
    }
}
