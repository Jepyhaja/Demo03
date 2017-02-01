using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student05
{
    class Student
    {
        //Props
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string StudentID { get; set; }
        public int LevelOfAttention { get; set; }
        public int CupsOfCoffee { get; set; }
        public int MissedClasses { get; set; }

        //Constructorit

            public Student()
        {
            FirstName = "Pekka";
            LastName = "Tolvana";
            StudentID = "424242";
            LevelOfAttention = 1;
            CupsOfCoffee = 3;
            MissedClasses = 0;
        }





        public Student(string firstname, string lastname, string studentid)
        {


      
            FirstName = firstname;
            LastName = lastname;
            StudentID = studentid;
        }

        public Student(int levelofattention, int cupsofcoffee, int missedclasses)
        {
          


            LevelOfAttention = levelofattention;
            CupsOfCoffee = cupsofcoffee;
            MissedClasses = missedclasses;

        }


        //Methods

        public void RunToClass()
        {
            Console.WriteLine(FirstName + " runs to class and can feel sweat pushing out. YIKES!");
            MissedClasses -= 1;
        }

        public void SlackOff()
        {
            Console.WriteLine(FirstName + " is 'taking it easy' and starts to get immersed into Reddit frontpage.");
            LevelOfAttention -= 7;
        }

        public void DrinkCoffee()
        {
            Console.WriteLine("You know coffee makes everything better " + FirstName + " , yet you certainly can't drink enough to make Monday feel ok.");
            LevelOfAttention += 12;
        }
        public void DataOut()
        {
            Console.WriteLine("First name > " + FirstName);
            Console.WriteLine("First name > " + LastName);
            Console.WriteLine("Student ID > " + StudentID);
            Console.WriteLine("Level of attention > " + LevelOfAttention);
            Console.WriteLine("Cups of coffee > " + CupsOfCoffee);
            Console.WriteLine("Missed classes > " + MissedClasses);
            Console.WriteLine();
            Console.WriteLine();
        }



    }
}
