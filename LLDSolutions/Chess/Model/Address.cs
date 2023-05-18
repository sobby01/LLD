using System;
using System.Collections.Generic;
using System.Text;

namespace LLDSolutions.Chess.Model
{
    public class Address
    {
        List<int> collection = new List<int>();
        
        private void Test()
        {
            collection.Add(1);
            collection.Add(3);
            collection.Add(5);
            collection.Add(2);

            int val = collection.Count;

            Array.Sort(collection.ToArray());
        }

        private String streetAddress;
        private String city;
        private String state;
        private String zipCode;
        private String country;
    }
}
