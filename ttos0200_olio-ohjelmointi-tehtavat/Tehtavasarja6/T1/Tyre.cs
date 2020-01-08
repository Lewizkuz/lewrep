using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T1
{
    class Tyre
    {
        public string Model { get; set; }
        public string Type { get; set; }
        public string Size { get; set; }
        public Tyre()
        {
         
        }
        public Tyre(string model, string type, string size)
        {
            Model = model;
            Type = type;
            Size = size;
           
        }
    }
}
