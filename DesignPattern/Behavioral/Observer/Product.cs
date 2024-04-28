using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Behavioral.Observer
{
    internal class Product : ProductContainer<float>
    {
        public Product() { }

        protected override void ChangePrice(float price)
        {
            Notify(price);
        }
    }
}
