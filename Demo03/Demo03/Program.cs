using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // create new instance form car class
            Car batmobile = new Car();
            batmobile.Model = "Batmobile 2.0";
            batmobile.DoorCount = 1;
            batmobile.Color = "Black as night";
            batmobile.Engine = 3.2;
            batmobile.Speed = 180;
            batmobile.Accelerate();
            batmobile.PrintData();
            batmobile.Brake(2);
            Car.SomeProperty = 1;
            batmobile.PrintData();

            // Create another car object
            string model = "speedster";

            Car nascar = new Car(model);
            nascar.PrintData();
            nascar.Color = "black";
            Console.WriteLine("color is " + nascar.Color);
            

        }
    }
}
