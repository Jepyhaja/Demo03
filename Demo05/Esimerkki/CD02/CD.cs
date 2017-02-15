using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CD02
{
   class CD
    {
        public List<Song> Songs { get; set; }

        public string CdName { get; set; }

        public string Artist { get; set; }

        public Double Price { get; set; }

        



        

        public override string ToString()
        {
            return CdName + " " + Artist + " " + Price + Songs;
            
        }
       


    }
}
