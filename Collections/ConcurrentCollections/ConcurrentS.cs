using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.Collections.ConcurrentCollections
{
    internal class ConcurrentS
    {

        public void Create()
        {
            ConcurrentStack<int> concurrentStack = new ConcurrentStack<int>();

            // Push
            concurrentStack.Push(1);
            concurrentStack.Push(2);

            // Pop
            if (concurrentStack.TryPop(out int result))
            {
                Console.WriteLine($"Popped value: {result}");
            }

            // Peek
            if (concurrentStack.TryPeek(out int peekedValue))
            {
                Console.WriteLine($"Peeked value: {peekedValue}");
            }
        }
    }
}
