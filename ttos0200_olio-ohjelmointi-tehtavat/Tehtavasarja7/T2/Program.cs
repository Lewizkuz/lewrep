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
            Dictionary<string, double> songs = new Dictionary<string, double>();
            CD cd = new CD
            {
                Name = "Sgt. Pepper’s Lonely Hearts Club Band",
                Artist = "The Beatles",
                Songs = songs
            };
            cd.AddSong("Sgt. Pepper’s Lonely Hearts Club Band", 2.02);
            cd.AddSong("With a Little Help from My Friends", 2.44);
            cd.AddSong("Lucy in the Sky with Diamonds", 3.28);
            cd.AddSong("Getting Better", 2.47);
            cd.AddSong("Fixing a Hole", 2.36);
            cd.AddSong("She’s Leaving Home", 3.35);
            cd.AddSong("Being for the Benefit of Mr. Kite! ", 2.37);
            cd.AddSong("Within You Without You", 5.05);
            cd.AddSong("When I’m Sixty-Four", 2.37);
            cd.AddSong("Lovely Rita", 2.42);
            cd.AddSong("Good Morning Good Morning", 3.41);
            cd.AddSong("Sgt. Pepper’s Lonely Hearts Club Band (Reprise)", 1.18);
            cd.AddSong("A Day in the Life", 5.33);

            cd.PrintInfo();
        }
    }
}
