
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Behavioral.Observer
{
    abstract class ProductContainer<T>
    {
        List<IObserver<T>> list = new List<IObserver<T>>();
        public ProductContainer() { }

        public void Attach(IObserver<T> product)
        {
            list.Add(product);
        }

        public void DeAttach(IObserver<T> product)
        {
            list.Remove(product);
        }

        public void Notify(T price)
        {
            foreach(var item in list)
            {
                item.Update(price);
            }
        }







        protected abstract void ChangePrice(T price);
    }
}
