using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpFeatures
{
    public class Tuples
    {
        public Tuple<int, string> CheckTuples()
        {
            Tuple<int, string> newTuple = new Tuple<int, string>(1, "Saurabh");

            List<Tuple<int, string>> listOfTuples = new List<Tuple<int, string>>
            {
                new Tuple<int, string>(1, "SS"),
                new Tuple<int, string>(2, "AB")
            };

            foreach(Tuple<int, string> d in listOfTuples)
            {
                Console.WriteLine(d.Item1);
                Console.WriteLine(d.Item2);
            }

            return newTuple;
        }
    }
}
