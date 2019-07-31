using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shopCart
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
    class ShoppingCart
    {
        private string username;
        private string password;
        private List<string> cart;
        private double cartTotal;

        public string Uname { get { return username; } set { username = value; } }
        public string Pword { get { return password; } set { password = value; } }
        public List<string> Cart { get { return cart; } set { cart = value; } }


        public double CartTotal()
        { return }
    }
}
