using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Factory.Version_2
{
    public class Factory
    {
        public Document GetDocumentFac(string type)
        {
            switch (type)
            {
                case "ConcreteDocument1":
                    return new ConcreteDocument1();
                case "ConcreteDocument2":
                    return new ConcreteDocument2();
            }

            return null;
        }
    }
}
