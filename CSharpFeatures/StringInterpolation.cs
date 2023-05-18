using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpFeatures
{
    //C# 6 feature
    public class StringInterpolation
    {
        public void ConcatStrings(string s1, string s2)
        {
            string s3 = string.Format("Name ={0}, Second Name = {1}", s1, s2);

            Console.WriteLine(s3);

            string s4 = $"Name={s1}, Second Name = {s2}";

            Console.WriteLine(s4);
        }
    }
}
