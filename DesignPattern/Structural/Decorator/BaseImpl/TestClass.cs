using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Structural.Decorator.BaseImpl
{
    public class TestClass
    {
        public void TestMethod()
        {
            Component component = new ConcreteComponent();

            ConcreteDecoratorA decoA = new ConcreteDecoratorA();
            ConcreteDecoratorB decoB = new ConcreteDecoratorB();

            decoA.SetComponent(component);
            decoB.SetComponent(decoA);

            decoB.DoOperation();

            Console.ReadKey();
        }
    }
}
