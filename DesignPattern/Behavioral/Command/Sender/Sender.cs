using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Behavioral.Command
{
    internal abstract class Sender
    {
        protected IReceiver receiver;

        protected Sender(IReceiver receiver)
        {
            this.receiver = receiver;
        }

        public abstract void Send(string message);
    }
}
