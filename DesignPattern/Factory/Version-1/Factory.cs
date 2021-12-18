using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Factory
{
    public class Factory
    {
        public ICarUnit GetFactoryUnit(string carType)
        {
            switch (carType)
            {
                case "Maruti":
                    return new MarutiCarInfo();
                case "Honda":
                    return new HondaCarInfo();
            }

            return null;
        }
    }
}
