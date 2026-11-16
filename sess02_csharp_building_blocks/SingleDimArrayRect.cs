using sess04_classes_methods;
using System;

namespace sess03_programming_constructs
{
    /// <summary>
    /// Program to demonstrate the use of reference/object types in single dimension
    /// arrays.
    /// </summary>
    public class SingleDimArrayRect
    {
        static void Main(string[] args)
        {
            // Declare an array of Rectangles
            Rect[] rectangles;

            //prompt the user for the number of rectagles they want to create
            Console.Write("Enter the number of rectangles you want to create: ");
            uint numRectangles = Convert.ToUInt32(Console.ReadLine());

            //initialise the rectangles array with the number of rectangles specified by the user
            rectangles = new Rect[numRectangles];

            uint len= 0, wid =0;
            //get the length and width of each rectangle from the user
            // Get the dimensions for the rectangles from the user
            for (uint n = 0; n < numOfRects; n++)
            {
                Console.WriteLine($"Please enter the length of rectangle {n + 1}:");
                len = Convert.ToUInt32(Console.ReadLine());
                Console.WriteLine($"Please enter the width of rectangle {n + 1}:");
                wid = Convert.ToUInt32(Console.ReadLine());
                rectangles[n] = new Rect(len, wid); // Instantiate the rectangle
                                                    // Display the rectangle's details
                Console.WriteLine(rectangles[n].ToString());
            }

        }
    }
}
