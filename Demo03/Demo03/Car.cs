using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarApp
{
    class Car
    {

        // OMINAISUUDET
        public string Model { get; set; }
        public string Color { get; set; }
        public double Engine { get; set; }
        public int Speed { get; set; }
        public bool FuzzyDices { get; set; }
        public int DoorCount { get; set; }
        public static int SomeProperty { get; set; }

        // vakio conssi
        public Car()
        {

        }


        // ei tehdä cosntructoria, käyteätän oletusta
        public Car(string model)
        {
            Model = model;
        }


        // nopuden lisäys toiminto
        public void Accelerate()
        {
            Speed += 5; // speed = speed + 5
        }

        // nopeuden vähennys toiminto
        public void Brake(int value)
        {
            Speed -= value; //speed = spedd - value
        }

        // auton tietojen näyttö toiminto
        public void PrintData()
        {
            Console.WriteLine("Car data:");
            Console.WriteLine("-model : " + Model);
            Console.WriteLine("-color : " + Color);
            Console.WriteLine("-engine : " + Engine);
            Console.WriteLine("-speed : " + Speed);
            Console.WriteLine("-dices : " + FuzzyDices);
            Console.WriteLine("-doorcount : " + DoorCount);
            Console.WriteLine("-someproperty : " + SomeProperty);
        }

        //destructor
        ~Car()
        {
            Console.WriteLine("Car object destroyed!");
        }



    }
}
