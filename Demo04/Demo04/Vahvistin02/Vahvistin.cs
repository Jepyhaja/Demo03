using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vahvistin02
{
    class Vahvistin
    {
        private int MaxVol = 100;
        private int MinVOl = 0;

        private int vol;
        public int Vol
        {
            get
            {
                return vol;
            }

            set
            {
                if(value <= MaxVol && value >= MinVOl)
                {
                    vol = value;
                }
                else if(value < MinVOl)
                {
                    Console.WriteLine("You cannot set volume lower than " + MinVOl);
                    Vol = vol;
                }

                else if(value < MaxVol)
                {
                    Console.WriteLine("You cannot set volume higher than " + MaxVol);
                    Vol = vol;
                }
            }
        }




    }
}
