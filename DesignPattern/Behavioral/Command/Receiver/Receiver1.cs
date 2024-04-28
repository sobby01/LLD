using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Behavioral.Command
{
    internal class Receiver1 : IReceiver
    {
        public void Execute(string message)
        {
           Console.WriteLine($"Execute from Receiver 1 { message}");
        }
    }
}
