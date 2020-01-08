using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T3
{
    class Program
    {
        static void Main(string[] args)
        {
            Fisherman man = new Fisherman("Make Mainio", "044-52132124");
            Fish cod = new Fish("Cod",200,2,"Vuorilapi","Jyväskylä");
            Fish salmon = new Fish("Salmon", 300, 3, "Ocean","Turku");
            man.Catch(cod);
            man.Catch(salmon);
            man.PrintCaught();
        }
    }
}
