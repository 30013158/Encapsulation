using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncapTask2
{
    class Program
    {
        static void Main(string[] args)
        {
            int h = 0;
            int w = 0;
            int l = 0;
            Box b1 = new Box(h,w,l);
            Console.WriteLine(b1.GetSufaceArea());
            Console.WriteLine(b1.GetVolume());
            Console.ReadLine();
        }

    }
    class Box
    {
        private int Height { get; set; }
        private int Width { get; set; }
        private int Length { get; set; }

        //methods to access the private properties and attributes
        public string GetSufaceArea()
        { return $"The surface area of the box is: {2 * ((Height * Width) + (Height * Length) + (Width * Length))}"; }

        public string GetVolume()
        { return $"The surface area of the box is: {Height * Width * Length} "; }

        //constructor
        public Box(int _height, int _width, int _length)
        {
            Height = _height;
            Width = _width;
            Length = _length;
            Console.WriteLine("Box object created ...");
        }
       
           
    }
}
