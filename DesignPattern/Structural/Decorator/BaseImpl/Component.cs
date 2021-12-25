using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Structural.Decorator.BaseImpl
{
    public abstract class Component
    {
        public abstract void DoOperation();
    }

    public class ConcreteComponent : Component
    {
        public override void DoOperation()
        {
            Console.WriteLine("I am the concrete component.");
        }
    }
}
