using System;
using System.Collections.Generic;
using System.Text;

namespace LLDSolutions.Splitwise.Models
{
    public class Metadata
    {
        public string ExpenseId { get; set; } //users and Group I can find through this expense id

        public string Comments { get; set; }

        public byte[] Image { get; set; }
    }
}
