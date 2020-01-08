using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T1
{
    class Program
    {
        static void Main(string[] args)
        {
            string syote = null;
            System.IO.StreamWriter file = null;
            //  Fetching file
            try
            {
                file = new System.IO.StreamWriter(@"D:\K8397\t1.txt");
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

            //  Loop to write names to line
            while (true)
            {
                Console.WriteLine("Give me names to put into file (end with null)");
                syote = Console.ReadLine();
                
                //  Lopetusehto
                if (syote == "") break;
                else file.WriteLine(syote);
            }
            file.Close();

            //  Print file contents
            Console.WriteLine("Contents of the file:");
            syote = System.IO.File.ReadAllText(@"D:\K8397\t1.txt");
            Console.Write(syote);
            file.Close();
        }
    }
}
