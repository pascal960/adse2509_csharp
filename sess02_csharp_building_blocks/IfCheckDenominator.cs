using System;

namespace sess03_programming_constructs
{
    /// <summary>
    /// Program to prevent division by zero '0' using the if construct
    /// </summary>
    public class IfCheckDenominator
    {
        static void Main(string[] args)
        {
            // Variables to be used in the program
            uint numerator, denominator, quotient;

            // Prompt the user for a numerator

            // Prompt the user for a numerator
            Console.WriteLine("Please enter a numerator to be used in division");
            numerator = Convert.ToUInt32(Console.ReadLine());
        UserPrompt: // Label that will be used in a goto statement

            // Prompt the user for a numerator
            Console.WriteLine("Please enter a numerator to be used in division");
            denominator = Convert.ToUInt32(Console.ReadLine());

            //check if the user entered a zero '0' for the denominator
            if (denominator == 0)
            {
                Console.WriteLine("please enter a non-0 value as division by"+
                    "zero will cause an error!");
                goto UserPrompt; 

            }
            quotient = numerator / denominator;
            // Display the result of the division
            Console.WriteLine("{0} {1} {2} = {3}", numerator, 
                '\u00f7', denominator, quotient);


        }
    }
    }
