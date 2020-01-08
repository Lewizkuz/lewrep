using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T3
{
    class Deck
    {
        const int COLOURSNUM = 4;
        const int NUMCARDS = 13;

        private readonly Random random;

        private Stack<Card> TmpDeck { get; set; }
        public Deck()
        {
            TmpDeck = new Stack<Card>();
        }
        public void MakeBasicDeck()
        {
            Console.WriteLine("Creating a basic deck of cards (count = 52, 13 spades, diamonds, clubs and hearts)");
            string input = "";
            for (int i = 0; i < COLOURSNUM; i++)
            {
                switch (i)
                {
                    case 0: input = "Spade"; break;
                    case 1: input = "Club"; break;
                    case 2: input = "Heart"; break;
                    case 3: input = "Diamond"; break;
                    default: Console.WriteLine("You broke my damn game you swine!"); break;
                }
                for (int j = 1; j <= NUMCARDS; j++)
                {
                    TmpDeck.Push(new Card(input, j));
                }
            }
        }
        public void Shuffle()
        {
            Card tmp = new Card();
            int s = 0;
            List<Card> ListDeck = TmpDeck.ToList();
            List<Card> Returnlist = new List<Card>();

            TmpDeck.Clear();

            for (int i = 0; i < TmpDeck.Count(); i++)
            {
                s = random.Next(0, ListDeck.Count - 1);
                tmp = ListDeck[s];
                Returnlist[i] = tmp;
                ListDeck.RemoveAt(s);
            }
            foreach (Card card in ListDeck)
            {
                TmpDeck.Push(card);
            }
        }
        public void PrintDeck()
        {
            if (TmpDeck.Count == 0) { Console.WriteLine("This deck contains no cards"); }
            else 
            {
                Console.WriteLine("Numcards: " + TmpDeck.Count);
                foreach (Card card in TmpDeck)
                {
                    Console.WriteLine("- " + card.ToString());
                }
            }
        }
    }
}
