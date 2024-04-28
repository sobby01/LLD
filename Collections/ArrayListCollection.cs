using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.Collection
{
    public class ArrayListCollection
    {
        public ArrayListCollection()
        {
            //In C#, the ArrayList is a non-generic collection of objects whose size increases dynamically.
            //It is the same as Array except that its size increases dynamically.
            //An ArrayList can be used to add unknown data where you don't know the types and the size of the data.
            //The ArrayList class implements the IList interface. So, elements can be accessed using indexer,
            //
            //in the same way as an array. Index starts from zero
            //and increases by one for each subsequent element.
            //An explicit casting to the appropriate types is required, or use the var variable.
        }

        public void Create()
        {
            ArrayList arlist = new ArrayList();
            // or 
            var arlist1 = new ArrayList(); // recommended 

            arlist1.Add(1);
            arlist1.Add("Bill");
            arlist1.Add(" ");
            arlist1.Add(true);
            arlist1.Add(4.5);
            arlist1.Add(null);

            var arlist2 = new ArrayList()
            {
                2, "Steve", " ", true, 4.5, null
            };
        }
    }
}
