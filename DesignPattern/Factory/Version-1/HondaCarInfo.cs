using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Factory
{
    public class HondaCarInfo : ICarUnit
    {
        public string GetCarInfo()
        {
            return "I am the Honda car";
        }
    }
}
