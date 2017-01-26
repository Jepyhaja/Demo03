using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeaterAppi
{
    class Heater
    {

        //properties

        public bool IsOn { get; set; }
        public int Temp { get; set; }
        public double Humidity { get; set; }


        public void ThrowWater()
        {
            Console.WriteLine("TShhhh");
        }
        public void AddWood()
        {
            Console.WriteLine("brrghhhhh");

        }
    }
}
