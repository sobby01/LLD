using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Behavioral.Observer
{
    internal interface IObserver<T>
    {
        void Update(T price);
    }
}
