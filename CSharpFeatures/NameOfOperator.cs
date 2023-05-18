using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpFeatures
{
    public class NameOfOperator
    {
        string name = "myval";

        public void MyMethod()
        {
            Console.WriteLine("My variable name is: " + nameof(name));
            //My variable name is: name
        }
    }
}
