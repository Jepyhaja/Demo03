using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicCollection03
{
    class Song
    {
        public string Name { get; set; }
        public string Length { get; set; }
        public string Format { get; set; }

        public Song()
        {
            Format = ".mp3";
        }

        public override string ToString()
        {
            return Name + " - " + Format + " " + Length;
        }
    }
}
