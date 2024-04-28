using System;
using LLDSolutions.RateLimiting;
using LLDSolutions.TicTacToe.API;
using LLDSolutions.TicTacToe.Game;

namespace LLDSolutions
{
    class Program
    {
        public static void Main(string[] args)
        {
            PlayTicTac();
            return;

            //UserSlidingWindow slidingWindow = new UserSlidingWindow(12345);
            //slidingWindow.AccessApp(12345);
            //slidingWindow.AccessApp(12345);
            //slidingWindow.AccessApp(12345);
            //slidingWindow.AccessApp(12345);
            //slidingWindow.AccessApp(12345); 
            //slidingWindow.AccessApp(12345);
        }

        private static void PlayTicTac()
        {
            Player p1 = new Player("testuser1", "t1", Symbol.X);
            Player p2 = new Player("testuser2", "t2", Symbol.O);

            Console.WriteLine("Game 1");
            Game ticTac = new Game(p1, p2);
            ticTac.Play(0, 0);
            ticTac.Play(0, 1);
            ticTac.Play(0, 2);
            ticTac.Play(1, 1);
            ticTac.Play(1, 0);
            ticTac.Play(2, 1);
            ticTac.Play(2, 2);

            Console.WriteLine("Game 2");
            ticTac = new Game(p1, p2);
            ticTac.Play(0, 0);
            ticTac.Play(0, 1);
            ticTac.Play(1, 1);
            ticTac.Play(1, 0);
            ticTac.Play(2, 2);
        }
    }
}
