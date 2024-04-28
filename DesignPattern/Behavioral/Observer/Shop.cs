using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Behavioral.Observer
{
    internal class Shop<T> : IObserver<T>
    {
        string name;
        T price;

        public Shop(string name)
        {
            this.name = name;
        }

        public void Update(T price)
        {
            this.price = price;
        }
    }
}
