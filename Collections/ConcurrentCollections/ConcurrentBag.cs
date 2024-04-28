using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.Collections.ConcurrentCollections
{
    internal class ConcurrentBag
    {

        public void Create()
        {
            ConcurrentBag<int> concurrentBag = new ConcurrentBag<int>();

            // Add
            concurrentBag.Add(1);
            concurrentBag.Add(2);

            // Take
            if (concurrentBag.TryTake(out int result))
            {
                Console.WriteLine($"Taken value: {result}");
            }
        }
    }
}
