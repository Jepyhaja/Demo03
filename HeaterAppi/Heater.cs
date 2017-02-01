using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeaterAppi01
{
    class Heater
    {

        //properties

        public bool IsOn { get; set; }
        public int Temp { get; set; }
        public double Humidity { get; set; }


        public void ThrowWater()
        {
            Humidity += 1.02;
        }
        public void AddWood()
        {
            Temp += 5;

        }
    }
}
