using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T3
{
    class Card
    {
        public readonly int MAXVALUE = 14;
        public readonly int MINVALUE = 0;

        public int CardnumReal { get; set; }
        public int Cardnum {
            get
            {
                return CardnumReal;
            }
            set
            {
                if (value > MAXVALUE)
                {
                    Console.WriteLine("Inserted value too big. setting to MAXVALUE = " + MAXVALUE);
                    CardnumReal = MAXVALUE;
                }
                else if (value < MINVALUE)
                {
                    Console.WriteLine("Inserted value too small. setting to MINVALUE = " + MINVALUE);
                    CardnumReal = MINVALUE;
                }
                else
                {
                    CardnumReal = value;
                }
            }
        }
        private string CardtypeReal { get; set; }
        public string CardType
        {
            get { return CardtypeReal; }
            set
            {
                switch (value)
                {
                    case "Club":
                        CardtypeReal = "Club";
                        break;
                    case "Heart":
                        CardtypeReal = "Heart";
                        break;
                    case "Spade":
                        CardtypeReal = "Spade";
                        break;
                    case "Diamond":
                        CardtypeReal = "Diamond";
                        break;
                    default:
                        Console.WriteLine("Inserted value is invalid");
                        break;
                }
            }
        }
        public Card()
        {

        }

        public Card(string type, int number)
        {
            CardType = type;
            Cardnum = number;
        }

        public override string ToString()
        {
            return "Type: " + CardType + " Number: " + Cardnum;
        }
    }
}
