using DesignPattern.Creational.Builder;
using deco = DesignPattern.Structural.Decorator.BaseImpl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignPattern.Behavioral.COR;
using DesignPattern.Behavioral.Command;
using DesignPattern.Behavioral.Interpreter;
using DesignPattern.Behavioral.Visitor;

namespace DesignPattern
{
    public class Program
    {
        static void Main(string[] args)
        {
            VisitorProcess vProcess = new VisitorProcess();
            vProcess.Process();

            InterpreterProcess intProcess = new InterpreterProcess();
            intProcess.CheckInterpreter();

            //SingletonNested sN = new SingletonNested();
            var intt = SingletonNested.Instance;

           CORDemo cordemo = new CORDemo();
           var loggerChain = cordemo.GetChainOfLoggers();

            loggerChain.LogMessage(AbstractLogger.INFO,
               "This is an information.");

            loggerChain.LogMessage(AbstractLogger.DEBUG,
               "This is an debug level information.");

            loggerChain.LogMessage(AbstractLogger.ERROR,
               "This is an error information.");

            DecoratorTest();
            //BuilderTest();
            Console.ReadLine();
        }
        public static void CommandTest()
        {
            IReceiver receiver = new Receiver1();
            Sender sender = new Sender1(receiver);
            Invoker invoker = new Invoker(sender);
            invoker.ExecuteCommand("Pass my message to receiver");
        }

        public static void DecoratorTest()
        {
            deco.TestClass decoTest = new deco.TestClass();
            decoTest.TestMethod();
        }

        public static void BuilderTest()
        {
            Director director = new Director();

            Builder b1 = new ConcreteBuilder1();
            Builder b2 = new ConcreteBuilder2();

            director.Construct(b1);
            Product p1 = b1.GetResult();
            p1.Show();

            director.Construct(b2);
            Product p2 = b1.GetResult();
            p2.Show();
        }
    }
}
