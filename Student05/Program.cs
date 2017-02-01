using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student05
{
    class Program
    {
        static void Main(string[] args)
        {
            Student vakio = new Student();
            
            vakio.DataOut();

            Student jarza = new Student();
            jarza.FirstName = "Jarza";
            jarza.LastName = "Gron";
            jarza.StudentID = "ABCK1554";
            jarza.LevelOfAttention = -9;
            jarza.MissedClasses = 7;
            jarza.CupsOfCoffee = 23;
            jarza.DrinkCoffee();
            jarza.SlackOff();
            jarza.DataOut();

            Student hemmo = new Student();
            hemmo.FirstName = "Hemmo";
            hemmo.LastName = "Hento";
            hemmo.StudentID = "4242424";
            hemmo.LevelOfAttention = 12;
            hemmo.MissedClasses = 2;
            hemmo.CupsOfCoffee = 2;
            hemmo.RunToClass();
            hemmo.DataOut();

            Student taituri = new Student();
            taituri.FirstName = "Yuri";
            taituri.LastName = "Taituri";
            taituri.StudentID = "696969";
            taituri.LevelOfAttention = 99;
            taituri.MissedClasses = 0;
            taituri.CupsOfCoffee = 65;
            taituri.DrinkCoffee();
            taituri.DataOut();

            Student slacker = new Student();
            slacker.FirstName = "Miina";
            slacker.LastName = "Granade";
            slacker.StudentID = "1234567";
            slacker.LevelOfAttention = -89;
            slacker.MissedClasses = 25;
            slacker.CupsOfCoffee = 0;
            slacker.SlackOff();
            slacker.DataOut();





        }
    }
}
