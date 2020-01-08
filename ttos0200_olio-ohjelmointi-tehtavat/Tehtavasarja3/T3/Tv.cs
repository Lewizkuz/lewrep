using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T3
{
    /// <summary>
    /// Television which can be turned on and off and its channel can be changed.
    /// </summary>
    class Tv
    {
        /// <summary>
        /// Is chosen Tv on or off. true = ON
        /// </summary>
        bool Ison { get; set; }
        /// <summary>
        /// Name of current channel. To change the channel: Setchannel.
        /// </summary>
        string Channel { get; set; }
        /// <summary>
        /// Constructor of the Tv
        /// </summary>
        public Tv()
        {
            Ison = false;
            Channel = "Yle Tv1";
            Console.WriteLine("Created TV (OFF)");
        }
        /// <summary>
        /// Turn the Power on if the tv is turned off and off if it's on.
        /// </summary>
        public void Power()
        {
            Console.WriteLine("* Pressed power button *");
            if (Ison) Ison = false;
            else Ison = true;
        }
        /// <summary>
        /// Prints all Channel options, asks the user of the channel until the input is valid and then sets the channel.   
        /// </summary>
        public void SetChannel()
        {
            Console.WriteLine("SetChannel:");
            if (Ison)
            {
                int input = 0;
                do
                {
                    Console.WriteLine("Choose the channel: (number)");
                    Console.WriteLine("- 1: Yle Tv1\n- 2: Yle Tv2\n- 3: MTV3 \n- 4: Nelonen\n- 5: Yle Fem\n- 6: SubTV");
                    input = int.Parse(Console.ReadLine());
                    switch (input)
                    {
                        case 1: Channel = "Yle Tv1"; break;
                        case 2: Channel = "Yle Tv2"; break;
                        case 3: Channel = "MTV3"; break;
                        case 4: Channel = "Nelonen"; break;
                        case 5: Channel = "Yle Fem"; break;
                        case 6: Channel = "SubTV"; break;
                        default: Console.WriteLine("Your input was invalid. You must insert the number of the channel"); break;
                    }
                } while (input == 0);
                Console.WriteLine("Current Channel: " + Channel);
            }
            else Console.WriteLine("Tv must be turned on before you could change channel.");
        }
        /// <summary>
        /// Shows if the tv is on and the channel if it is on. 
        /// </summary>
        public void ShowInfo()
        {
            Console.WriteLine("ShowInfo:");
            Console.WriteLine("This is current info of your TV: \n- Power On: " + Ison);
            if (Ison) Console.WriteLine("- Channel: " + Channel);
        }
    }
}
