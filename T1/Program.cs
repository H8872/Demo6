using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T1
{
    class Program
    {
        static void Main(string[] args)
        {
            // ceate an object from Persons
            Persons myFrinds = new Persons();

            // create few frinds
            Person person1 = new Person { Firstname = "Jussi", Lastname = "Jurkka", SocialSecurityNumber = "010101-01E6" };
            Person person2 = new Person { Firstname = "Tuomas", Lastname = "Veturi", SocialSecurityNumber = "123666-1337" };
            Person person3 = new Person { Firstname = "Liisa", Lastname = "Tuomio", SocialSecurityNumber = "060606-9939" };

            // add persons to collection
            myFrinds.AddPerson(person1);
            myFrinds.AddPerson(person2);
            myFrinds.AddPerson(person3);

            // print collection
            myFrinds.PrintCollection();

            // get one person
            Console.WriteLine("Get one person from collection:");
            Person person4 = myFrinds.Getperson(1);
            if (person4 != null)
            {
                Console.WriteLine(person4.ToString());
            }
            else
            {
                Console.WriteLine("Cannot find person in that position");
            }

            //find person with sotu
            string socialSecurityNumber = "010101-01E6";
            Person person5 = myFrinds.FindPerson(socialSecurityNumber);
            Console.WriteLine("Find person with sotu:");
            if(person5 != null)
            {
                Console.WriteLine(person5.ToString());
            }
            else
            {
                Console.WriteLine("Cannot find person with that sotu");
            }

        }
    }
}
