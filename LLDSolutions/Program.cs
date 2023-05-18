using System;
using LLDSolutions.RateLimiting;

namespace LLDSolutions
{
    class Program
    {
        public static void Main(string[] args)
        {
            UserSlidingWindow slidingWindow = new UserSlidingWindow(12345);
            slidingWindow.AccessApp(12345);
            slidingWindow.AccessApp(12345);
            slidingWindow.AccessApp(12345);
            slidingWindow.AccessApp(12345);
            slidingWindow.AccessApp(12345); 
            slidingWindow.AccessApp(12345);
        }
    }
}
