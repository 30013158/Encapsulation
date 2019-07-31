using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UML
{
    class Program
    {
        static void Main(string[] args)
        {
            /* 1st Method - Simple
             
             Person p1 = new Person();
             Person.counter = 1;
             p1.Fname = "Rajveer";
             p1.Lname = "Kaur";
             p1.Age = 19;
             Console.WriteLine((p1.ReturnDeets()));
             Console.ReadLine();*/

            /* 2 Method
            
            List<Person> people = new List<Person>();
            Person.counter = 0;

            string check = "y";
            while(check == "y")
            {
                Console.Clear();
                Person.counter++;
                Person p1 = new Person();
                Console.Write($"Enter the first name of person: ");
                p1.Fname = Console.ReadLine();
                Console.Write($"Enter the last name of person: ");
                p1.Lname = Console.ReadLine();
                Console.Write($"Enter the age of person: ");
                p1.Age = int.Parse(Console.ReadLine());
                people.Add(p1);

                Console.WriteLine("Would you like to add another person(y/n): ");
                check = Console.ReadLine().ToLower();

                Console.WriteLine($"The number of people created: {Person.counter}");

                foreach(Person x in people)
                    Console.WriteLine($"\nName{x.Fname} {x.Lname} \nAge: {x.Age}");
                Console.ReadLine(); */

            /*Version 2*/
            Person p1 = new Person();
            List<Person> peeps = new List<Person>()
                {
                   new Person("Raj", "Kaur", 19),
                    new Person("Jassi", "Singh", 24),
                    new Person("Avi", "jeet", 19),
                };
                Console.WriteLine($"The number of people created: {Person.counter}");
                foreach (Person x in peeps)
                    Console.WriteLine($"\nName{x.Fname} {x.Lname} \nAge: {x.Age}");
                Console.ReadLine();

        }


        }
    }
    class Person
    {
        private string fname;
        private string lname;
        private int age;
        public static int counter = 0;

        public string Fname { get { return fname; } set { fname = value; } }
        public string Lname { get { return lname; } set { lname = value; } }
        public int Age { get { return age; } set { age = value; } }

        public string ReturnDeets()
        {
            return $"Name: {Fname} {Lname}\n" +
                  $"Age : {Age}";
        }
        public Person() { }
        public Person(string _fname, string _lname, int _age)
        { Fname = _fname;
            Lname = _lname;
            Age = _age;
            counter++;
        }
    }
}
