using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Structural.Decorator.BaseImpl
{
    public abstract class Decorator : Component
    {
        protected Component component;
        public void SetComponent(Component comp)
        {
            this.component = comp;
        }

        public override void DoOperation()
        {
            component.DoOperation();
        }
    }

    public class ConcreteDecoratorA : Decorator
    {
        public override void DoOperation()
        {
            base.DoOperation();
            Console.WriteLine("I am concrete decorator A");
        }
    }

    public class ConcreteDecoratorB : Decorator
    {
        public override void DoOperation()
        {
            base.DoOperation();
            //New Behaviour added 
            AddBehavior();
            Console.WriteLine("I am concrete decorator B");
        }

        public void AddBehavior()
        {

        }
    }
}
