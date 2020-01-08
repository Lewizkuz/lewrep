using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T2
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                System.IO.File.Exists(@"C:\Users\leevi\OneDrive\Asiakirjat/t1.txt");
            }
            catch (ArgumentNullException)
            {
                Console.WriteLine("Stream has no value (is null). ");
                return;
            }
            catch (ArgumentException)
            {
                Console.WriteLine("Stream is not writable");
                return;
            }
            string [] names = System.IO.File.ReadAllLines(@"C:\Users\leevi\OneDrive\Asiakirjat/t1.txt");
            Name[] nameoliot = new Name[names.Length];
            int s = 0;
            foreach (string name in names)
            {
                nameoliot[s] = new Name(name);
                s++;
            }
            nameoliot.OrderBy(name => name.Namestring);
            for (int i = 1; i < names.Length; i++)
            {
                if (nameoliot[i-1].Namestring == nameoliot[i].Namestring)
                {
                    nameoliot[i].Count++;
                }
            }
            Console.WriteLine("Löytyi " + nameoliot.Count() + " riviä, ja " + nameoliot.Count() + " nimeä");
           for (int i= 0; i < nameoliot.Length; i++)
            { 
                Console.WriteLine("Nimi {0} esiintyi {1}", nameoliot[i].Namestring, nameoliot[i].Count);
            }

        }
    }
}
