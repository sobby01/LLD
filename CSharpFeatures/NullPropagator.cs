using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpFeatures
{
    public class NullPropagator
    {
        public string Name { get; set; }
        public string Age { get; set; }


        public void TestNull()
        {
            Name = "Saurabh";
            Age = "32";

            Console.WriteLine(Name?.ToUpperInvariant() ?? "Name is Empty");
            Console.WriteLine(Age?.ToUpperInvariant() ?? "Age is Empty");
        }

    }
}
