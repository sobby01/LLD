using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.Collection
{
    public class SortedDictionaryCollection
    {
        public void Create()
        {
            // Creating a SortedDictionary
            SortedDictionary<int, string> sortedDictionary = new SortedDictionary<int, string>();

            // Adding key-value pairs
            sortedDictionary.Add(3, "Three");
            sortedDictionary.Add(1, "One");
            sortedDictionary.Add(2, "Two");

            // Iterating through key-value pairs (sorted by key)
            foreach (var pair in sortedDictionary)
            {
                Console.WriteLine($"{pair.Key}: {pair.Value}");
            }

            // Removing a key-value pair
            sortedDictionary.Remove(1);

            // Displaying state after removal
            Console.WriteLine("\nSortedDictionary after removing key 1:");
            // Iterating through key-value pairs (sorted by key)
            foreach (var pair in sortedDictionary)
            {
                Console.WriteLine($"{pair.Key}: {pair.Value}");
            }
        }
    }
}
