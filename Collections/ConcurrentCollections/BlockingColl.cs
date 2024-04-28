using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.Collections.ConcurrentCollections
{
    internal class BlockingColl
    {

        public void Create()
        {
            BlockingCollection<int> blockingCollection = new BlockingCollection<int>(new ConcurrentQueue<int>());

            // Producer
            Task.Run(() =>
            {
                for (int i = 0; i < 5; i++)
                {
                    blockingCollection.Add(i);
                    Console.WriteLine($"Produced: {i}");
                }

                blockingCollection.CompleteAdding();
            });

            // Consumer
            Task.Run(() =>
            {
                foreach (var item in blockingCollection.GetConsumingEnumerable())
                {
                    Console.WriteLine($"Consumed: {item}");
                }
            });

            Task.WaitAll();
        }
    }
}
