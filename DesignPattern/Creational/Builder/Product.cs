using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Creational.Builder
{
    public class Product
    {
        public List<string> productParts = new List<string>();

        public void Add(string part)
        {
            productParts.Add(part);
        }

        public void Remove(string part)
        {
            productParts.Remove(part);
        }

        public void Show()
        {
            Console.WriteLine("Product Parts");
            foreach (string part in productParts)
            {
                Console.WriteLine(part);
            }
                
        }
    }
}
