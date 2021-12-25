using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Structural.Facade.BaseImpl
{
    public class SubSystemOne
    {
        public void MethodOne()
        {
            Console.WriteLine("Method 1");
        }
    }

    public class SubSystemTwo
    {
        public void MethodTwo()
        {
            Console.WriteLine("Method 2");
        }
    }

    public class SubSystemThree
    {
        public void MethodThree()
        {
            Console.WriteLine("Method 3");
        }
    }

}
