using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS
{
    public class TestHierarchy
    {
        public TestHierarchy()
        {
            Console.WriteLine("TestHierarchy constructor");
        }

        public void DoIt(int x)
        {
            Console.WriteLine($"TestHierarchy Inside DoIt {x}");
        }
    }

    public class TestHierarchy2 : TestHierarchy
    {
        public TestHierarchy2() : base()
        {
            Console.WriteLine("TestHierarchy2 constructor");
        }

        public void DoIt(int y)
        {
            base.DoIt(y);
            DoX(y);
        }

        public void DoX(int y)
        {
            Console.WriteLine($"TestHierarchy2 Inside DoIt {y}");
        }
    }

    public class TestHierarchy3 : TestHierarchy2
    {
        public TestHierarchy3() : base()
        {
            Console.WriteLine("TestHierarchy3 constructor");
        }

        public void Doit(int x)
        {
            base.DoIt(x);
            Console.WriteLine($"TestHierarchy3 Inside DoIt {x}");
        }
    }
}
