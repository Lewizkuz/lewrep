using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T3
{
    class CD
    {
        public string Name { get; set; }
        public string Artist { get; set; }
        public Dictionary<string, double> Songs {get;set;}

        public CD()
        {

        }
        public CD(string name, string artist, Dictionary<string,double> songs)
        {
            Name = name;
            Artist = artist;
            Songs = songs;
        }
        public void PrintInfo()
        {
            Console.WriteLine("CD data:");
            Console.WriteLine("- name: "+ Name+"\n- artist: "+ Artist+"\n- songs:");
            foreach (string key in Songs.Keys)
            {
                Console.WriteLine(" - "+key+ ", "+ Songs[key]);
            }
        }
        public void AddSong(string song, double length)
        {
            Songs.Add(song, length);
        }
    }
}
