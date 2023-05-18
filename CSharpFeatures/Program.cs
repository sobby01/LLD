    using System;

namespace CSharpFeatures
{
    class Program
    {
        static void Main(string[] args)
        {
            MulticastDelegate mcDelegate = new MulticastDelegate();
            mcDelegate.TestMultiCastDelegate();
            Console.ReadKey();
            return;

            DelegateImpl dImpl = new DelegateImpl();
            //dImpl.TestDelegate();
            Console.ReadKey();
            return;
            DynamicBinding dBinding = new DynamicBinding();
            dBinding.DynamicMethod();
            Console.ReadKey();
        }
    }
}
