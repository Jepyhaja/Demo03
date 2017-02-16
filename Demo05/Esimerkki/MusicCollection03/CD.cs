using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicCollection03
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
        /// <summary>
        /// Adds song to CD collection and formats it to CD
        /// </summary>
        /// <param name="song"></param>
        public void AddSongs(Song song)
        {
            songs.Add(song);
            song.Format = "CD";
        }






        public  Data()
        {
            Console.WriteLine(CdName + "\n" + Artist + "\n" + Price + "\n");
                foreach (Song song in songs)
            {
                Console.WriteLine(song.ToString());
            }
        }
        
            
        
    }
}
