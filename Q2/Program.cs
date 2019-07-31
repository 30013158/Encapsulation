using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q2
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee[] peeps = new Employee[5];
            for(int i = 0; i < 5; i++)
            {
                Employee e1 = new Employee();
                Console.Write("Name: ");
                e1.Name = Console.ReadLine();
                Console.Write("Age: ");
                e1.Age = int.Parse(Console.ReadLine());
                peeps[i] = e1;
            }

        }
        static void Display (Employee[] arr)
        {
            foreach(Employee e in arr)
                Console.WriteLine(e.Name);
        }
    }
    class Employee
    {
        public string Name { get; set; }
        public int Age { get; set; }

    }
}
