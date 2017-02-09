using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo05
{
    class Program
    {
        static void Main(string[] args)
        {
            // create person objects
            Person person1 = new Person
            {
                Firstname = "Jari", Lastname = "Kernel", SocialSecurityNumber = "1234-13"
            };

            Person person2 = new Person
            {
                Firstname = "Kirsi",
                Lastname = "Kernel",
                SocialSecurityNumber = "2345-19"
            };

            Person person3 = new Person
            {
                Firstname = "Lari",
                Lastname = "Onntts",
                SocialSecurityNumber = "3456-22"
            };

            Person person4 = new Person
            {
                Firstname = "Jani",
                Lastname = "Du'pont",
                SocialSecurityNumber = "4567-15"
            };

            //create Persons object
            Persons myFriends = new Persons();


            //add person objects to persons collection

            myFriends.AddPersons(person1);
            myFriends.AddPersons(person2);
            myFriends.AddPersons(person3);
            myFriends.AddPersons(person4);

            //get one person form persons collection
            Person person5 = myFriends.GetPerson(10);
                if(person5 != null)
            {
                Console.WriteLine(person5.ToString());
            }
            else
            {
                Console.WriteLine("Person not found or does not exist in that index!");
            }

            //print collection
            myFriends.PrintCollection();

            //find person
            string ssn = "2345-19";
            Console.WriteLine("Find SSN : " + ssn);
            Person person6 = myFriends.FindPerson(ssn);
            if (person6 != null)
            {
                Console.WriteLine(person6.ToString());
            }else
            {
                Console.WriteLine("can't find person with that SSN!");
            }



        }
    }
}
