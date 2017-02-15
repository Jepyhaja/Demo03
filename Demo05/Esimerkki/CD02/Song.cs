using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CD02
{
  class Song
    {
        public string Name { get; set; }
        public string Length { get; set; }

        public Song()
        {

        }

        public override string ToString()
        {
            return Name + " " + Length;
        }

    }
}
