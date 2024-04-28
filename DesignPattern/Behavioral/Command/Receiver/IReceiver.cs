using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Behavioral.Command
{
    internal interface IReceiver
    {
        void Execute(string message);
    }
}
