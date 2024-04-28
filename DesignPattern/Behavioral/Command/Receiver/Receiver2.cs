using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Behavioral.Command
{
    internal class Receiver2 : IReceiver
    {
        public void Execute(string message)
        {
            Console.WriteLine($"Execute from Receiver 2 {message}");
        }
    }
}
