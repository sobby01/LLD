using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpFeatures
{
    public class DynamicBinding
    {
        public dynamic Name { get; set; }

        public dynamic ShowMsg(string msg)
        {
            return msg;
        }

        public void DynamicImpl()
        {
            this.Name = "Saurabh Singh";

            Console.WriteLine(this.Name);

            dynamic msg = ShowMsg("This is Saurabh");
            Console.Write(msg);
        }

        public void DynamicMethod()
        {
            dynamic v = 1;
            object v1 = 1;

            Console.WriteLine(v.GetType());
            Console.WriteLine(v1.GetType());
        }
    }
}
