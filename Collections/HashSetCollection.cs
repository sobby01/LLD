using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.Collection
{
    public class HashSetCollection
    {
        public HashSetCollection() { }

        public void Create()
        {
            // Creating a HashSet of integers
            HashSet<int> numbers = new HashSet<int>();

            // Adding elements to the HashSet
            numbers.Add(1);
            numbers.Add(2);
            numbers.Add(3);
            numbers.Add(2); // Duplicate elements are automatically ignored
            
            // Checking if an element is present
            Console.WriteLine($"Is 3 present in the HashSet? {numbers.Contains(3)}"); // Output: True

            // Removing an element
            numbers.Remove(2);

            // Iterating through the HashSet
            Console.WriteLine("HashSet elements:");
            foreach (int number in numbers)
            {
                Console.WriteLine(number);
            }
        }
    }
}
