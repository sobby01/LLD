using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.Collection
{
    public class Dictionary
    {
        public Dictionary() { }

        public void Create()
        {
            // Creating a Dictionary
            Dictionary<int, string> dictionary = new Dictionary<int, string>
            {
                { 3, "Three" },
                { 1, "One" },
                { 2, "Two" }
            };

            int length = dictionary.Count;

            // Sorting the Dictionary by key using LINQ
            var sortedDictionary = dictionary.OrderBy(x => x.Key).ToDictionary(x => x.Key, x => x.Value);

            // Iterating through key-value pairs (sorted by key)
            foreach (var pair in sortedDictionary)
            {
                Console.WriteLine($"{pair.Key}: {pair.Value}");
            }
        }
    }
}
