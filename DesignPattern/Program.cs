using DesignPattern.Creational.Builder;
using deco = DesignPattern.Structural.Decorator.BaseImpl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern
{
    public class Program
    {
        static void Main(string[] args)
        {
            DecoratorTest();
            //BuilderTest();
            Console.ReadLine();
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
