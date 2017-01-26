using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PesukoneApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Pesukone pesukone = new Pesukone();

            pesukone.IsOn = true;
            pesukone.SlingMode = true;
            pesukone.WaterTemps = 300;
            pesukone.Time = 25;

            pesukone.Sling();
            pesukone.BounceAround();

            pesukone.Dataout();

        }
    }
}
