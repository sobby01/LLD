using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.Collections
{
    internal class SortedSetCollection
    {
        public void Func()
        {
            // Creating a SortedSet
            SortedSet<int> sortedSet = new SortedSet<int>();

            // Adding elements
            sortedSet.Add(3);
            sortedSet.Add(1);
            sortedSet.Add(2);

            // Iterating through elements (sorted)
            foreach (var element in sortedSet)
            {
                Console.WriteLine(element);
            }

            // Removing an element
            sortedSet.Remove(1);

            // Displaying state after removal
            Console.WriteLine("\nSortedSet after removing element 1:");
            foreach (var element in sortedSet)
            {
                Console.WriteLine(element);
            }
        }
    }
}
