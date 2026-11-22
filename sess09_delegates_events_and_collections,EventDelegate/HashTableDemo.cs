using System;
using System.Collections;
using sess07_properties_records_indexers;


namespace sess09_delegates_events_and_collections_EventDelegate
{
    /// <summary>
    /// Program to demonstrate the Hashtable class
    /// </summary>
    public class HashTableDemo
    {
        static void Main(string[] args)
        {
            uint n = 0;

            Hashtable bookTable = new Hashtable();

            bookTable.Add(101, new Book(578, "C# How to Program", "Deitel & Deitel", 7100.0f));
            bookTable.Add(102, new Book(579, "C# Notes for Professionals", "Et al", 5000.0f));
            bookTable.Add(103, new Book(580, "C# 9.0 in a Nutshell", "Joseph Albahari", 6000.0f));
            bookTable.Add(104, new Book(581, "C# 9 and .NET 5 – Modern Cross-Platform Development", "Mark J. Price", 8000.0f));
            bookTable.Add(105, new Book(582, "C# 9.0 Pocket Reference", "Joseph Albahari", 4000.0f));
            bookTable.Add(106, new Book(583, "Clean Code", "Robert C. Martin", 4500.0f));
            bookTable.Add(107, new Book(584, "The Pragmatic Programmer", "David Thomas & Andrew Hunt", 5200.0f));
            bookTable.Add(108, new Book(585, "Head First Java", "Kathy Sierra & Bert Bates", 3800.0f));

            // Display the number of books in the Hashtable
            Console.WriteLine($"The number of books in the dictionary is: {bookTable.Count}");

            // Get a collection of keys from the books Hashtable
            ICollection bookTableKeys = bookTable.Keys;

            // Display the bookTable keys
            Console.WriteLine("The bookTable keys are:" + "\n" + new string('-', 55));

            foreach (var key in bookTableKeys)
            {
                Console.WriteLine($"Key: {key}");
            }
        }
    }
}