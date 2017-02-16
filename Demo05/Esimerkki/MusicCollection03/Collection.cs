using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicCollection03
{
    class Collection
    {
        public List<CD> CDs { get; set; }

        public List<Song>Songs { get; set; }


        public Collection()
        {
            CDs = new List<CD>();
            Songs = new List<Song>();
        }

       public void AddSong(Song song)
        {
            Songs.Add(song);
            song.Format = ".mp3";
        }
        public void AddCDs(CD cd)
        {
            CDs.Add(cd);
        }


        public void PrintData()
        {
            foreach(CD cd in CDs)
            {
                Console.WriteLine("CD data: \n" + cd.Data());

            }
        }


    }
}
