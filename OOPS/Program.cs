using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //TestHierarchy th = new TestHierarchy3();
            //th.DoIt(3);
            //Console.ReadKey();
            //Console.WriteLine("*************************");
            //TestHierarchy2 th2 = new TestHierarchy3();
            //th2.DoIt(3);
            //Console.ReadKey();
            //Console.WriteLine("*************************");
            TestHierarchy3 th3 = new TestHierarchy3();
            th3.DoIt(3);
            Console.ReadKey();
            Console.WriteLine("*************************");
        }
    }
}
