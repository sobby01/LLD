using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.Collections.IComparerSolutions
{
    public class MultiColumnComparer : IComparer<int[]>
    {
        private readonly int columnToCompare;

        public MultiColumnComparer(int column)
        {
            columnToCompare = column;
        }

        public int Compare(int[] a, int[] b)
        {
            return a[columnToCompare].CompareTo(b[columnToCompare]);
        }
    }
}
