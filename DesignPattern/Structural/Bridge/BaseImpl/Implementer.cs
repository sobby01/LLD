using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Structural.Bridge
{
    public abstract class Implementer
    {
        public abstract void Operation();
    }

    public class ConcreteImplementer1 : Implementer
    {
        public override void Operation()
        {
            Console.WriteLine("I am inside concrete implementer 1");
        }
    }

    public class ConcreteImplementer2 : Implementer
    {
        public override void Operation()
        {
            Console.WriteLine("I am inside concrete implementer 2");
        }
    }
}
