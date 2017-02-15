using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CD02
{
    class Program
    {
        static void Main(string[] args)
        {
            CD cd = new CD02.CD();
            cd.Artist = "Nightwish";
            cd.CdName = "Endless Forms Most Beautiful";
            cd.Price = 26.50;

            Song song1 = new Song { Name = "Shudder Before the Beautiful", Length = "6:29" };
            Song song2 = new Song { Name = "Weak Fantasy", Length = "5:23" };
            Song song3 = new Song { Name = "Elan", Length = "4:45" };
            Song song4 = new Song { Name = "My Walden", Length = "4:38" };


            cd.AddSongs(song1);
            cd.AddSongs(song2);
            cd.AddSongs(song3);
            cd.AddSongs(song4);

            cd.PrintData();
            




        }
    }
}
