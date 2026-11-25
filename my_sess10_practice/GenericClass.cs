using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace sess10_generics_and_iterators
{
    /// <summary>
    /// A simple generic container that holds a fixed number of items of any type.
    /// </summary>
    public class GenericClass<T> : IEnumerable<T>
    {
        private readonly T[] items;
        private int count; // How many items have been added so far

        public GenericClass(int size)
        {
            items = new T[size];
            count = 0;
        }

        public int Count => count;

        public void AddItem(T item)
        {
            if (count >= items.Length)
            {
                Console.WriteLine("The collection is full. Item not added.");
                return;
            }
            items[count] = item;
            count++;
        }

        // Iterator: lets you use foreach on this class
        public IEnumerator<T> GetEnumerator()
        {
            for (int i = 0; i < count; i++)
                yield return items[i];
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"The collection has {count} item(s):");
            for (int i = 0; i < count; i++)
                sb.AppendLine($"  {i + 1}. {items[i]}");
            return sb.ToString();
        }
    }
}
