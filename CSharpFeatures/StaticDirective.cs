using System;
using System.Collections.Generic;
using System.Text;
using static System.Math;

namespace CSharpFeatures
{
    public class StaticDirective
    {

        public void PrintMax()
        {
            int max1 = 40;

            //Here using the old way by typing the class name.
            int max3 = Math.Max(40, max1);

            Console.Write(max3);

            //using static directive : using static System.Math;
            int max2 = Max(43, max1);

            Console.WriteLine(max2);
        }
    }
}
