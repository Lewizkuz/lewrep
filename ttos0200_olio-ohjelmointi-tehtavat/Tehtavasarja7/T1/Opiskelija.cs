using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T1
{
    class Opiskelija
    {
        //  Muuttujat
        public string Etunimi { get; set;}
        public string Sukunimi { get; set; }
        public string AsioId { get; set; }
        public string Ryhma { get; set; }

        //  Constructors
        public Opiskelija()
        {

        }
        public Opiskelija(string etunimi, string sukunimi)
        {
            Etunimi = etunimi;
            Sukunimi = sukunimi;
        }

        public override string ToString()
        {
            return string.Format("{0} {1} {2} {3}", Etunimi, Sukunimi, AsioId, Ryhma);
        }

    }
}
