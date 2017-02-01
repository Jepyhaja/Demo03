using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeaterAppi01
{
    class Program
    {
        static void Main(string[] args)
        {
            Heater heater = new Heater();
            heater.IsOn = true;
            heater.Humidity = 20.76;
            heater.Temp = 120;
            heater.AddWood();

            Console.WriteLine(heater.Humidity);
            Console.WriteLine(heater.IsOn);
            Console.WriteLine(heater.Temp);
        
        }
    }
}
