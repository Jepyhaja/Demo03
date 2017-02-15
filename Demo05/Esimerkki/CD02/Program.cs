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
            cd.Artist = "NW";
            cd.Price = 16.50;
            cd.CdName = "NAME";

            Song song = new Song();
            song.Name = "elan";
            
            

            

            Collection mycds = new Collection();

            mycds.addCD(cd);
           

            mycds.PrintCollection();


        }
    }
}
