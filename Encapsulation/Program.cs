using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation
{
    class Program
    {
        static void Main(string[] args)
        {
            CreditCard c1 = new CreditCard();
            c1.Name = "RAJVEER KAUR";
            c1.Number = "1233 4343 4333";
            c1.Pin = 2425;
            c1.Expiry = new DateTime(2033, 10, 10);
            Console.WriteLine($"... Credit card info...\n" + $"Name : {c1.Name}\n" + $"Expiration : {c1.Expiry}");
            Console.ReadLine();
        }
    }
    public class CreditCard
    { //attributes
        private string name;
        private string number;
        private int pin;
        private DateTime expiry;
        //properties - getters and setters
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string Number
        {
           private get { return number; }
            set { number = value; }
        }
        public int Pin
        {
           private get { return pin; }
            set { pin = value; }
        }
        public DateTime Expiry
        {
            get { return expiry; }
            set { expiry = value; }
        }
        //Constructors
        public CreditCard( string _name , string number, int pin, DateTime expiry)
        { Name = _name;
            Number = number;
            Pin = pin;
            Expiry = expiry;
        }
         public CreditCard() { }
    }
}
