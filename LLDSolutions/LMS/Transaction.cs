using System;
using System.Collections.Generic;
using System.Text;

namespace LLDSolutions.LMS
{
    public abstract class Transaction
    {
        public DateTime TransactionDate { get; private set; }


        public abstract bool ProcessAmount(double amount);
    }

    public class CreditCardTransaction : Transaction
    {
        public override bool ProcessAmount(double amount)
        {
            throw new NotImplementedException();
        }
    }

    public class CheckTransaction : Transaction
    {
        public override bool ProcessAmount(double amount)
        {
            throw new NotImplementedException();
        }
    }

    public class CashTransaction : Transaction
    {
        public override bool ProcessAmount(double amount)
        {
            throw new NotImplementedException();
        }
    }
}
