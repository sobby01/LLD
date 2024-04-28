using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.Collections.IComparerSolutions
{
    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }

    public class PersonComparer : IComparer<Person>
    {
        public int Compare(Person a, Person b)
        {
            return a.Age.CompareTo(b.Age);
        }
    }
}
