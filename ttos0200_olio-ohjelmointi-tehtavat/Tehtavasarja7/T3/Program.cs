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
            Deck deck = new Deck();
            deck.PrintDeck();
            deck.MakeBasicDeck();
            deck.PrintDeck();
            deck.ToString();
            Console.WriteLine("Now we shuffle the deck and print its contents!");
            deck.Shuffle();
            deck.PrintDeck();
        }
    }
}
