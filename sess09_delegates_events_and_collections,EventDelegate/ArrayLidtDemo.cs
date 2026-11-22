using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace sess09_delegates_events_and_collections_EventDelegate
{
    internal class ArrayLidtDemo
    {
        static void Main(string[] args)
        {
            ArrayList fruitList = new ArrayList();

            // Display the initial capacity of the fruitList object
            Console.WriteLine($"The initial capacity of the 'fruitList' is: {fruitList.Capacity}");

            // Add fruits to the fruitList
            fruitList.Add("Apple");
            fruitList.Add("Peach");
            fruitList.Add("Banana");
            fruitList.Add("Orange");
            fruitList.Add("Mango");
            fruitList.Add("Pineapple");
            fruitList.Add("Watermelon");
            fruitList.Add("Strawberry");
            fruitList.Add("Dragon Fruit");
            fruitList.Add("Plums");
            fruitList.Add("cherry");
            fruitList.Add("kiwi");
            fruitList.Add("Durian");
            fruitList.Add("grapes");
            fruitList.Add("cherry");
            fruitList.Add("kiwi");
            fruitList.Add("blackberry");
            fruitList.Add("kiwi");
            fruitList.Add("beetroot");
            fruitList.Add("kiwi");

            // Display the original list of fruits
            Console.WriteLine($"The original fruitList has {fruitList.Count} fruits, and" +
                              $" they are listed below: ");
            foreach (string fruit in fruitList)
                Console.WriteLine(fruit);

            // Insert a fruit before 'mango'
            fruitList.Insert(4, "Lemon");

            // Replace 'orange' with 'Kiwi fruit'
            fruitList[3] = "Kiwi fruit";

            //Display the modified and unsorted list of fruits
            Console.WriteLine($"\nThe modified fruitList has {fruitList.Count} fruits, and" +
                              $" they are listed below: ");

            for (uint n = 0; n < fruitList.Count; n++)
                Console.WriteLine($"{(n + 1):00}. {fruitList[(int)n]}");

            // Sort the 'fruitList' in reverse lexicographical (descending) order
            fruitList.Sort(); // Sort fruitList in ascending order
            fruitList.Reverse(); // Reverse the above sort (effectively sorting them in descending
                                 // order)

            Console.WriteLine($"The fruitList in reverse lexicographical order is:");
            for (uint n = 0; n < fruitList.Count; n++)
                Console.WriteLine($"{(n + 1):00}. {fruitList[(int)n]}");
        }
    }
}