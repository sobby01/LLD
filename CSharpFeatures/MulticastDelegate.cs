using CSharpTestApp;
using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpFeatures
{
    public class MulticastDelegate
    {
        TestClass tClass = new TestClass();

        public void TestMultiCastDelegate()
        {
            TestClass.SendResult abc = null;
            abc += new TestClass.SendResult(tClass.Method1);
            abc += new TestClass.SendResult(tClass.Method2);
            abc += new TestClass.SendResult(tClass.Method3);

            abc(432);
            abc -= new TestClass.SendResult(tClass.Method2);
            abc(432);
            Console.ReadKey();

            //tClass.toSend = CallBackMethod;
            //tClass.CalculateFactorial(5);
        }

        public void CallBackMethod(int number)
        {
            Console.WriteLine(number);
        }
    }
}
