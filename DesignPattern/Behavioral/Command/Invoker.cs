using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Behavioral.Command
{
    internal class Invoker
    {
        private Sender sender;

        internal Invoker(Sender sender) 
        {
            this.sender = sender;

        }

        public void ExecuteCommand(string message)
        {
            sender.Send(message);
        }
    }
}
