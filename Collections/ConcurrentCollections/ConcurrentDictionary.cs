using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.Collections.ConcurrentCollections
{
    internal class ConcurrentDictionary
    {

        public void Create()
        {
            ConcurrentDictionary<string, int> concurrentDictionary = new ConcurrentDictionary<string, int>();

            // Adding key-value pairs
            concurrentDictionary.TryAdd("one", 1);
            concurrentDictionary.TryAdd("three", 3);
            concurrentDictionary["two"] = 2;

            // Updating values
            concurrentDictionary.AddOrUpdate("one", 10, (key, oldValue) => oldValue + 10);

            // Reading values
            int value;

            if (concurrentDictionary.TryGetValue("two", out value))
            {
                Console.WriteLine($"Value for key 'two': {value}");
            }
            // Remove item with key 2
            concurrentDictionary.TryRemove("three", out int removedValue);

            Console.WriteLine($"Removed Value': {value}");

            if (removedValue != 0)
            {
                Console.WriteLine($"Removed item with key 2, value: {removedValue}");
            }

            // Iterating through key-value pairs
            foreach (var pair in concurrentDictionary)
            {
                Console.WriteLine($"{pair.Key}: {pair.Value}");
            }
        }
    }
}
