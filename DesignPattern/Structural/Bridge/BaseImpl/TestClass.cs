using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Structural.Bridge.BaseImpl
{
    public class TestClass
    {
        public void TestMethod()
        {
            Abstraction ab = new RefinedAbstraction();

            ab.Implementor = new ConcreteImplementer1();
            ab.Operation();

            //Now we can change the implementor

            ab.Implementor = new ConcreteImplementer2();
            ab.Operation();
        }
    }
}
