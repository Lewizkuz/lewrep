using System;

namespace T10
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] taulukko = { 1, 2, 33, 44, 55, 68, 77, 96, 100 };

            for( int i = 0; i < taulukko.Length; i++ )
            {
                Console.Write(taulukko[i]);
                if(taulukko[i] % 2 == 0)Console.Write("  HEP");
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
