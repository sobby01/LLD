using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Structural.Proxy
{
    public abstract class Subject
    {
        public abstract void Request();
    }

    public class RealSubject : Subject
    {
        public override void Request()
        {
            Console.WriteLine("Called Real Subject");
        }
    }

    public class Proxy : Subject
    {
        RealSubject rSubject;
        public override void Request()
        {
            if(rSubject == null)
            {
                rSubject = new RealSubject();
            }

            rSubject.Request();
        }
    }
}
