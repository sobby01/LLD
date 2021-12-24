using System;
using System.Collections.Generic;
using System.Text;

namespace LLDSolutions.Splitwise.Models
{
    public class Transaction
    {
        public User Payee { get; set; }

        public User Payer { get; set; }

        public double Amount { get; set; }
    }
}
