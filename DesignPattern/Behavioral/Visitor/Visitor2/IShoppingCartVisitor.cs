using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Behavioral.Visitor.Visitor2
{
    public interface IShoppingCartVisitor
    {
        int Visit(Book book);
        int Visit(Fruit fruit);
    }
}
