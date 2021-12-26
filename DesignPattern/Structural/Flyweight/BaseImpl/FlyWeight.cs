using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Structural.Flyweight.BaseImpl
{
    public interface FlyWeight
    {
        void Operation();

        void DoAction();
    }

    public class ConcreteFlyweight1 : FlyWeight
    {
        public void DoAction()
        {
            Console.WriteLine("Do Action at concrete flyweight 1");
        }

        public void Operation()
        {
            Console.WriteLine("I am the concrete flyweight 1");
        }


    }

    public class ConcreteFlyweight2 : FlyWeight
    {
        public void Operation()
        {
            Console.WriteLine("I am the concrete flyweight 2");
        }
        public void DoAction()
        {
            Console.WriteLine("Do Action at concrete flyweight 2");
        }
    }
}
