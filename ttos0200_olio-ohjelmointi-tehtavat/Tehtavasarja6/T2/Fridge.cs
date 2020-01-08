using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T2
{
    class Fridge
    {
        public List<Product> Objects { get; set; }
        public Fridge()
        {

        }
        public Fridge(List<Product> objects)
        {
            Objects = objects;
        }
    }
}
