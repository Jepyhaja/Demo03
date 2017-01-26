using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PesukoneApp
{
    class Pesukone
    {

        //props
        public bool IsOn { get; set; }
        public bool SlingMode { get; set; }
        public bool DrySling { get; set; }
        public int WaterTemps { get; set; }
        public int Time { get; set; }


        //metods
        public void Sling()
        {
            Console.WriteLine("sling sling sling");
        }

        public void Rumble()
        {
            Console.WriteLine("Intimidating rumble echoes from far far away!");
        }
        public void BounceAround()
        {
            Console.WriteLine("As you walk towards your wahsingmachien it starts to bounce all around the room violently.");
        }
        public void Dataout()
        {

            Console.WriteLine(SlingMode);
            Console.WriteLine(DrySling);
            Console.WriteLine(WaterTemps);
            Console.WriteLine(Time);
            Console.WriteLine(SlingMode);

        }

    }
}
