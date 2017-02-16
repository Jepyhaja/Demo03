using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicCollection03
{
    class Program
    {
        static void Main(string[] args)
        {

            CD cd = new CD();
            cd.Artist = "SSS";
            cd.CdName = "fff";
            cd.Price = 23.4;
            Song song1 = new Song();
            song1.Name = "song1";
            song1.Length = "3:42";
            song1.Format = "mp3";
            cd.AddSongs(song1);
            cd.PrintData();

            CD cd2 = new CD();
            cd2.Artist = "CD2";
            cd2.CdName = "CD2name";
            Song song2 = new Song();
            song2.Name = "Song2";
            cd2.AddSongs(song2);
            cd2.PrintData();
        }
    }
}
