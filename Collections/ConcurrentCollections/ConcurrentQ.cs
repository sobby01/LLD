using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.Collections.ConcurrentCollections
{
    internal class ConcurrentQ
    {

        public void Create()
        {
            ConcurrentQueue<int> concurrentQueue = new ConcurrentQueue<int>();

            // Enqueue
            concurrentQueue.Enqueue(1);
            concurrentQueue.Enqueue(2);

            int length = concurrentQueue.Count();

            Stack<int> st = new Stack<int>();
            int length1 = st.Count;

            int[] arr = new int[] { 5, 2, 3, 4 };

            int l1 = arr.Length;

            // Dequeue
            if (concurrentQueue.TryDequeue(out int result))
            {
                Console.WriteLine($"Dequeued value: {result}");
            }

            // Peek
            if (concurrentQueue.TryPeek(out int peekedValue))
            {
                Console.WriteLine($"Peeked value: {peekedValue}");
            }
        }
    }
}
