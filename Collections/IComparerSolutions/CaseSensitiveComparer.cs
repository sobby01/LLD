using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.Collections.IComparerSolutions
{
    public class CaseInsensitiveStringComparer : IComparer<string>
    {
        public int Compare(string a, string b)
        {
            return string.Compare(a, b, StringComparison.OrdinalIgnoreCase);
        }
    }
}
