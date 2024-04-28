using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Behavioral.Interpreter
{
    // Context class (holds global information)
    public class Context
    {
        public string Input { get; set; }
        public int Output { get; set; }
    }
}
