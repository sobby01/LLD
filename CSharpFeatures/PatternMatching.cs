using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpFeatures
{
    public class Emp
    {
        public string Name
        {
            get;
            set;
        }
    }

    public class PatternMatching
    {
        

        public bool CheckPattern(string n)
        {
            Emp e = new Emp();
            if (e is Emp)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
