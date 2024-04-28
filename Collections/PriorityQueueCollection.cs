using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.Collection
{
    public class School
    {
        public string Name { get; set; } = string.Empty;
        public int Age { get; set; }
        public School(string name, int age)
        {
            Name = name;
            Age = age;
        }
    }

    public class PriorityQueueCollection
    {
        PriorityQueue<School, int> hospitalQueue = null;
        public void Func()
        {
            hospitalQueue = new PriorityQueue<School, int>();

            var patients = new List<(School, int)>()
            {
                (new("Sarah", 23), 4),
                (new("Joe", 50), 2),
                (new("Elizabeth", 60), 1),
                (new("Natalie", 16), 5),
                (new("Angie", 25), 3)
            };

            hospitalQueue = new PriorityQueue<School, int>(patients);
            var element = hospitalQueue.Dequeue();
            Console.WriteLine(element.Name);
        }

        public void PriorityQueueInts()
        {
            int k = 4;
            int[] nums = new int[] { 3,2,1,5,6,4 };
            PriorityQueue<int, int> minHeap = new PriorityQueue<int, int>();

            foreach(var item in nums)
            {
                minHeap.Enqueue(item, item);
                if(minHeap.Count > k)
                {
                    minHeap.Dequeue();
                }
            }
            Console.WriteLine(minHeap.Peek());
        }



        public void PriorityQueueMaxHeap()
        {
            int k = 4;
            int[] nums = new int[] { 3, 2, 1, 5, 6, 4 };
            PriorityQueue<int, int> maxHeap = new PriorityQueue<int, int>(Comparer<int>.Create((x, y) => y - x));

            foreach (var item in nums)
            {
                maxHeap.Enqueue(item, item);
                if (maxHeap.Count > k)
                {
                    maxHeap.Dequeue();
                }
            }
            Console.WriteLine(maxHeap.Peek());
        }

        public void FuncIntegers()
        {
            //var intQueue = new PriorityQueue();

            //Descending Sort, Integer
            var queue = new PriorityQueue<int, int>(Comparer<int>.Create((x, y) => y - x));
            queue.Enqueue(1,1);
        }
    }
}
