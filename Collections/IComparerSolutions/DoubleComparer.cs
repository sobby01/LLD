using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.Collections.IComparerSolutions
{
    public class DoubleComparer : IComparer<double>
    {
        public int Compare(double a, double b)
        {
            return a.CompareTo(b);
        }
    }
}
