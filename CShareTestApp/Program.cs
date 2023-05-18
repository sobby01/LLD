using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTestApp
{
    public class TestClass
    {

        public delegate void SendResult(int number);
        public SendResult toSend;

        public void TMethod()
        {
            Console.WriteLine("Print Something");
        }

        public void CalculateFactorial(int number)
        {
            int result = number;
            for (int i = 1; i < number; i++)
            {
                result = result * i;
            }

            toSend.Invoke(result);
        }

        public void Method1(int message)
        {
            Console.WriteLine($"First Message : {message}");
        }

        public void Method2(int message)
        {
            Console.WriteLine($"Second Message : {message}");
        }

        public void Method3(int message)
        {
            Console.WriteLine($"Third Message : {message}");
        }

    }

}
