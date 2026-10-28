using System;

namespace sess02_csharp_building_blocks
{
    /// <summary>
    /// Program to demonstrate C# numeric format specifiers.
    /// </summary>
    public class NumericSpecifiers
    {
        static void Main(string[] args)
        {
            // Variables to hold sample numbers
            int intValue = 123457;
            double doubleValue = 321457.789;
            decimal decValue = 123457.987m;


        // Currency format specifier (C)
        Console.WriteLine("Currency Format (C):");
            Console.WriteLine(new string('-', 70));
            Console.WriteLine(intValue.ToString("C"));
            Console.WriteLine($"{intValue:c}");
            Console.WriteLine(doubleValue.ToString("C"));
            Console.WriteLine($"{doubleValue:c}");
            Console.WriteLine(decValue.ToString("C"));
            Console.WriteLine($"{decValue:c}");
            Console.WriteLine(new string('-', 70));

            // Decimal format specifier (D)
            Console.WriteLine("Decimal Format (D):");
            Console.WriteLine(new string('-', 70));
            Console.WriteLine(intValue.ToString("D"));
            Console.WriteLine($"{intValue:d}");
            Console.WriteLine($"{123:d7}");
            Console.WriteLine(123.ToString("D7"));
            Console.WriteLine(new string('-', 70));

            // Exponential format specifier (E)
            Console.WriteLine("Exponential Format (E):");
            Console.WriteLine(new string('-', 70));
            Console.WriteLine($"{doubleValue:E}");
            Console.WriteLine($"{intValue:e}");
            Console.WriteLine(new string('-', 70));

            // Fixed-point format specifier (F)
            Console.WriteLine("Fixed-point Format (F):");
            Console.WriteLine(new string('-', 70));
            Console.WriteLine($"{doubleValue:F}");
            Console.WriteLine($"{doubleValue:F4}");
            Console.WriteLine(new string('-', 70));

            // General format specifier (G)
            Console.WriteLine("General Format (G):");
            Console.WriteLine(new string('-', 70));
            Console.WriteLine($"{doubleValue:G}");
            Console.WriteLine($"{intValue:G}");
            Console.WriteLine(new string('-', 70));

            // Number format specifier (N)
            Console.WriteLine("Number Format (N):");
            Console.WriteLine(new string('-', 70));
            Console.WriteLine($"{doubleValue:N}");
            Console.WriteLine($"{doubleValue:N4}");
            Console.WriteLine(new string('-', 70));

            // Percentage format specifier (P)
            Console.WriteLine("Percentage Format (P):");
            Console.WriteLine(new string('-', 70));
            double percentage = 0.85;
            Console.WriteLine(percentage.ToString("P"));
            Console.WriteLine($"{percentage:P}");
            Console.WriteLine(new string('-', 70));

            // Hexadecimal format specifier (X)
            Console.WriteLine("Hexadecimal Format (X):");
            Console.WriteLine(new string('-', 70));
            Console.WriteLine(intValue.ToString("X"));
            Console.WriteLine($"Hexadecimal with padding (X7): {intValue:x7}");
            Console.WriteLine(new string('-', 70));
        }
    }


}
