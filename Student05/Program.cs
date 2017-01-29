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



        }
    }
}
