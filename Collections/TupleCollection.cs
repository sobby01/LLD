using DSA.Collections.IComparerSolutions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.Collections
{
    public class TupleCollection
    {
        Tuple<int, string, string> person;

        Tuple<int, string, string> person2;

        Tuple<int, int, int, int, int, int> integerCollection;
        
        public TupleCollection()
        {
            //The Tuple is a reference type and not a value type.
            //It allocates on heap and could result in CPU intensive operations.
            //The Tuple is limited to include eight elements.
            //You need to use nested tuples if you need to store more elements.However, this may result in ambiguity.
            //The Tuple elements can be accessed using properties
            //with a name pattern Item<elementNumber>, which does not make sense.
        }

        private void Initialize()
        {
            person =
            new Tuple<int, string, string>(1, "Steve", "Jobs");
            

            person2 = Tuple.Create(1, "Steve", "Jobs");

            integerCollection = Tuple.Create(1, 2, 3, 4, 5, 6);
        }

        private void Access()
        {
            Console.WriteLine(person.Item1); // returns 1
            Console.WriteLine(person.Item2); // returns "Steve"
            Console.WriteLine(person.Item3); // returns "Jobs"


            Console.WriteLine(integerCollection.Item1); // returns "One"
            Console.WriteLine(integerCollection.Item2); // returns 2
            Console.WriteLine(integerCollection.Item3); // returns 3
            Console.WriteLine(integerCollection.Item4); // returns "Four"
            Console.WriteLine(integerCollection.Item5); // returns 5
            Console.WriteLine(integerCollection.Item6); // returns "Six"
        }

        private void NestedTuples()
        {
            var numbers = Tuple.Create(1, 2, 3, 4, 5, 6, 7, Tuple.Create(8, 9, 10, 11, 12, 13));
            Console.WriteLine(numbers.Item1); // returns 1
            Console.WriteLine(numbers.Item7); // returns 7
            Console.WriteLine(numbers.Rest.Item1); //returns (8, 9, 10, 11, 12, 13)
            Console.WriteLine(numbers.Rest.Item1.Item1); //returns 8
            Console.WriteLine(numbers.Rest.Item1.Item2); //returns 9
        }
    }
}
