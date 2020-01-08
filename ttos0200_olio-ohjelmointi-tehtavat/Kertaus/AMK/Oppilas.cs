using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AMK
{
    class Oppilas
    {
        public string Nimi { get; set; }
        public string Asioid { get; set; }

        public Oppilas( string nimi, string asioid)
        {
            this.Nimi = nimi;
            this.Asioid = asioid;
        }
        public Oppilas()
        {

        }
    public string NäytäTiedot()
        {
            return "Nimi: " + Nimi + " ASIO: " + Asioid;
        }
    }
}
