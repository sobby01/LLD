using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Structural.Facade.BaseImpl
{
    public class Facade
    {
        SubSystemOne systemOne;
        SubSystemTwo systemTwo;
        SubSystemThree systemThree;

        public Facade()
        {
            systemOne = new SubSystemOne();
            systemTwo = new SubSystemTwo();
            systemThree = new SubSystemThree();
        }

        public void MethodA()
        {
            Console.WriteLine("Method A");
            systemOne.MethodOne();
            systemTwo.MethodTwo();
        }

        public void MethodB()
        {
            Console.WriteLine("Method B");
            systemThree.MethodThree();
        }
    }
}
