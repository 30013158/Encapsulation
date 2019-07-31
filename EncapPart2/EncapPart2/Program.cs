using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncapPart2
{
    class Program
    {
        static void Main(string[] args)
        {
            int h = 0;
            int w = 0;
            int l = 0;

            Box b1 = new Box(h, w, l);
            Console.ReadLine();

            
        }
        static int GetData (int number, string info)
        {
            bool check = true;
            bool confirm = false;
        }
    }
    class Box
    {
        //hidden attributes
        private int Height;
        private int Width;
        private int Length;

        //methods to access prop
        public string GetSurfaceArea()
        { return $"The surface area of the box is: {2 * ((Height * Width) + (Height * Length) + (Length * Width))}"; }

        public string GetVolume()
        { return $"The volume of the box is: {Length * Height * Width}"; }

        //constructor
        public Box(int _height, int _width, int _length)
        {
            Height = _height;
            Width = _width;
            Length = _length;
            Console.WriteLine("Box object created....");
        }






    }
}
