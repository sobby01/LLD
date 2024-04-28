using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Behavioral.Command
{
    internal class Sender1 : Sender
    {
        public Sender1(IReceiver receiver) : base(receiver)
        {
            Console.WriteLine($"Receiver {receiver} associated with Sender1");
        }

        public override void Send(string message)
        {
            receiver.Execute(message);
        }
    }
}
