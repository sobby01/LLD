using System;
using System.Collections.Generic;
using System.Text;

namespace LLDSolutions.Splitwise.Models
{
    public class EqualExpense : Expense
    {
        public EqualExpense(double amount, User paidBy, Metadata metadata, List<ExpenseDetails> splitInformation) : 
            base(amount, paidBy, metadata, splitInformation)
        {
        }

        public override bool Validate()
        {

            //Add a logic

            throw new NotImplementedException();
        }
    }
}
