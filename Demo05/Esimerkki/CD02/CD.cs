using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CD02
{
   class CD
    {
        

        public List<Song> songs { get; set; }
       
        public string CdName { get; set; }

        public string Artist { get; set; }

        public Double Price { get; set; }

       
        public CD()
        {
            songs = new List<Song>();
        }

        public void AddSongs(Song song)
        {
            songs.Add(song);
        }






        public void PrintData()
        {
            Console.WriteLine("> " + CdName + "\n> " + Artist + "\n> " + Price);
            foreach (Song song in songs)
            {
                Console.WriteLine(song.ToString());
            }
        }







    }
}
