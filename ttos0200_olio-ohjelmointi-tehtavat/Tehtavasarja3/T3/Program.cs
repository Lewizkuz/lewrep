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
            Tv tele = new Tv();
            tele.SetChannel();
            tele.ShowInfo();
            tele.Power();
            tele.ShowInfo();
            tele.SetChannel();
        }
    }
}
