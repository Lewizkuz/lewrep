using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T7
{
    class Program
    {
        static void Main(string[] args)
        {
            //  Tee ohjelma, joka lajittelee kahdessa kokonaislukutaulukossa olevat alkiot suurusjärjestykseen 
            //  kolmanteen kokonaislukutaulukkoon. 
            //  Tulosta lopuksi lajitellun taulukon sisältö.
            int[] t1 = { 10, 20, 30, 40, 50 };
            int[] t2 = { 5, 15, 25, 35, 45 };
            int[] t3 = new int[t1.Length + t2.Length];
            Console.WriteLine("Numbers in array 1: " + t1);
            Console.Write("Numbers in array 2: " + t2);

            
            Console.ReadLine();
        }
    }
}
