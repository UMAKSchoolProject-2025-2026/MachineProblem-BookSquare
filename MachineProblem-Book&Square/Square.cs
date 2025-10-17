using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MachineProblem_Book_Square
{
    class Square
    {
        //fields

        private int length;
        private int width;

        //properties
        public int Length
        {
            get { return length; }
            set { length = value; }
        }

        public int Width
        {
            get { return width; }
            set { width = value; }
        }

        //constructor
        public Square(int length, int width)
        {
            this.length = length;
            this.width = width;
        }

        public Square()
        {
            length = 1;
            width = 1;
        }

        //methods
        public int GetArea()
        {
            return this.length * this.width;
        }

        public int GetPerimeter()
        {
            return 2 * (this.length + this.width);
        }

        // Display info
        public void Display()
        {
            Console.WriteLine($"Length: {length}");
            Console.WriteLine($"Width: {width}");
            Console.WriteLine($"Perimeter: {GetPerimeter()}");
            Console.WriteLine($"Area: {GetArea()}");
        }

        ~Square()
        {
            Console.WriteLine("Square object destroyed.");
        }
    }
}
