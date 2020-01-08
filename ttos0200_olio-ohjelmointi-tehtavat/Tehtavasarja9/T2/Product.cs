using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T2
{
    class Product
    {
        public string Name { get; set; }
        private double PriceReal { get; set; }
        public double Price
        {
            get {
                return PriceReal;
            }
            set {
                if (value < 0)  {
                    PriceReal = 0;
                }
                else   {
                    PriceReal = value;
                }
            }
        }
        public Product(string name, double price)
        {
            Name = name;
            Price = price;
        }
    }
}
