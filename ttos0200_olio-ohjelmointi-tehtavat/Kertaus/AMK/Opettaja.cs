using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AMK
{
    class Opettaja
    {
        public string Nimi { get; set; }
        public string Tunnus { get; set; }

        public Opettaja(string nimi, string asioid)
        {
            this.Nimi = nimi;
            this.Tunnus = asioid;
        }
        public Opettaja()
        {

        }
        public string NäytäTiedot()
        {
            return "Opettajan tiedot:\n\tNimi: " + Nimi + " ASIO: " + Tunnus;
        }
    }
}
