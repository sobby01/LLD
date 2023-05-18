using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpFeatures
{
    public class DefaultValuesOfGetter
    {
        public string Name { get; } = "Saurabh";

        public string FullName { get; set; } = "Saurabh Singh";

        public string CheckGetter()
        {
            Console.WriteLine(Name);

            return Name;
        }

        public string CheckAutoProperty()
        {
            Console.WriteLine(FullName);

            return FullName;
        }
    }
}
