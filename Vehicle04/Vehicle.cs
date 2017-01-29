using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicle04
{
    class Vehicle
    {
        //props
        public string name { get; set; }
        public int speed { get; set; }
        public int tyres { get; set; }

        //const


        //methods
        public void PrintData()
        {
            Console.WriteLine("Your vehicle name is: " + name);
            Console.WriteLine("Your vehicle spees is: " + speed);
            Console.WriteLine("Your vehhilce has " + tyres + " tyres");
        }

        public void ToString()
        {
            string Speed = speed.ToString();
            string Tyres = tyres.ToString();
            Console.WriteLine(name + " " + Speed + " " + Tyres);
        }





    }
}
