using System;
using System.Collections.Generic;
using System.Text;

namespace LLDSolutions.RateLimiting
{
    public class UserSlidingWindow
    {
        private Dictionary<int, SlidingWindow> bucket;

        public UserSlidingWindow(int requestId)
        {
            bucket = new Dictionary<int, SlidingWindow>();

            bucket.Add(requestId, new SlidingWindow(1, 10));
        }


        public void AccessApp(int id)
        {
            if (bucket[id].GrantAccess())
            {
                Console.WriteLine("Access granted");
            }

            Console.WriteLine("Request denied");
        }
    }
}
