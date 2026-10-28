using System;
using System.Collections.Generic;
using System.Text;

namespace classes_and_methods
{
    internal class Rect
    {
        // Fields
        private double length;
        private double width;

        // Constructor
        public Rect(double length, double width)
        {
            this.length = length;
            this.width = width;
        }

        // Method to calculate area
        public double CalculateArea()
        {
            return length * width;
        }

        // Method to calculate perimeter
        public double CalculatePerimeter()
        {
            return 2 * (length + width);
        }

        // Method to display details
        public void Display()
        {
            Console.WriteLine("Length: " + length);
            Console.WriteLine("Width: " + width);
            Console.WriteLine("Area: " + CalculateArea());
            Console.WriteLine("Perimeter: " + CalculatePerimeter());
        }
    }
}

