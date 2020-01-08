using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T2
{
    class Product
    {
        private int PriceReal { get; set; }
        public int Price {
            get
            {
                return PriceReal;
            }
            set
            {
                if (value < 0) PriceReal = 0;
                else PriceReal = value;
            }
        }
    
        public Product()
        {

        }
    }
}
