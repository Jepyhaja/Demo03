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
            Console.WriteLine("As you walk towards your wahsingmachine it starts to bounce all around the room violently.");
        }
        public void Dataout()
        {

            Console.WriteLine("-Slingmode: " + SlingMode);
            Console.WriteLine("-Dryslingmode: " + DrySling);
            Console.WriteLine("Water temperature: " + WaterTemps);
            Console.WriteLine("Time remaining: " + Time);
            

        }

    }
}
