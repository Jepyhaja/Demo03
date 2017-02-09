using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicle04
{
    class Program
    {
        static void Main(string[] args)
        {
            Vehicle veh = new Vehicle();
            veh.name = "megabiili";
            veh.speed = 160;
            veh.tyres = 8;
            veh.PrintData();
            veh.ToString();
            veh.name = "megabiiliV2";
            veh.speed = 165;
            veh.tyres = 8;
            veh.PrintData();
            veh.ToString();




        }
    }
}
