using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Behavioral.COR
{
    public class ErrorLogger : AbstractLogger
    {
        public ErrorLogger(int level)
        {
            this.level = level;
        }
        protected override void Write(string message)
        {
            Console.WriteLine($"Error Logger : {message}");
        }
    }
}
