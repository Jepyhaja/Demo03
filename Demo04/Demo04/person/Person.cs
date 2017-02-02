using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Personapp
{
    class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public int Age { get; set; }
        public string PhoneNumber { get; set; }


        //constructors

        public Person()
        {
        }

        public Person(string firstname, string lastname)
        {
            FirstName = firstname;
            LastName = lastname;
    
    }






        public void PersonMethod()
        {
            Console.WriteLine("This method belongs to Person");

        }

        public override string ToString()
        {
            return FirstName + " " + LastName + " " + Address + " " + PhoneNumber; 
        }
        



        }


    }


