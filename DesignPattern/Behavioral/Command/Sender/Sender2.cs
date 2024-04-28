using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Behavioral.Command
{
    internal class Sender2 : Sender
    {
        public Sender2(IReceiver receiver) : base(receiver)
        {
            Console.WriteLine($"Receiver {receiver} associated with Sender1");
        }

        public override void Send(string message)
        {
            Console.WriteLine($"Execute from Receiver 2 {message}");
        }
    }
}
