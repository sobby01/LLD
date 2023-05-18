using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Text;

namespace LLDSolutions.RateLimiting
{
    public interface IRateLimiter
    {
        bool GrantAccess();
    }


    public class SlidingWindow : IRateLimiter
    {
        private ConcurrentQueue<int> slidingWindow;
        private int bucketCap;
        private int time;

        public SlidingWindow(int time, int cap)
        {
            this.time = time;
            this.bucketCap = cap;
            slidingWindow = new ConcurrentQueue<int>();
        }

        public bool GrantAccess()
        {
            long currentTime = DateTime.Now.Millisecond;
            Console.WriteLine("Current Time : {0}", currentTime);
            long timeInSec = currentTime / 1000;
            UpdateQueue(currentTime);
            Console.WriteLine("Time in Sec : {0}", timeInSec);
            if (slidingWindow.Count < bucketCap)
            {
                slidingWindow.Enqueue((int)currentTime);
                return true;
            }

            return false;
        }

        public void UpdateQueue(long currentTime)
        {
            if (slidingWindow.Count <= 0) return;
            slidingWindow.TryPeek(out int resultTime); //Oldest time
            long time = (currentTime - resultTime) / 1000; //actual time in seconds

            while (time >= this.time)
            {
                slidingWindow.TryDequeue(out int removedTimeFrame);
                if (slidingWindow.Count <= 0) break;
                slidingWindow.TryPeek(out int oldresultTime);
                time = (currentTime - oldresultTime) / 1000;
            }

        }

    }
}
