
using System;

namespace sess02_csharp_building_blocks
{
    /// <summary>
    /// Demonstrates the use of if, else if and else statements to greet a user
    /// according to the hour entered.
    /// </summary>
    internal class If_ElseIfTimeGreeting
    {
        static void Main(string[] args)
        {
            // Variable to hold the user's name
            Console.Write("Please enter your name: ");
            String? name = Console.ReadLine();

            // Get the hour from the user
            Console.Write("Enter an hour between 0 and 23: ");
            uint curhour = Convert.ToUInt32(Console.ReadLine());

            // Greet the user based on the entered hour
            if (curhour >= 0 && curhour <= 11)
            {
                Console.WriteLine($"Good morning, {name}!");
            }
            else if (curhour >= 12 && curhour <= 17)
            {
                Console.WriteLine($"Good afternoon, {name}!");
            }
            else if (curhour >= 18 && curhour <= 21)
            {
                Console.WriteLine($"Good evening, {name}!");
            }
            else if (curhour >= 22 && curhour <= 23)
            {
                Console.WriteLine($"Good night, {name}!");
            }
            else
            {
                Console.WriteLine("Invalid hour entered.");
            }
        }
    }
}

