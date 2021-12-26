using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Structural.Flyweight.BaseImpl
{
    public class TestFlyWeight
    {
        public void TestMethod()
        {
            FlyweightFactory factory = new FlyweightFactory();
            FlyWeight flywght = factory.GetFlyWeightObject("concrete1");
            flywght.Operation();
            flywght.DoAction();
        }
    }
}
