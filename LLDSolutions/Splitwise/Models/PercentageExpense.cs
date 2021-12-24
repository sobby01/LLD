using System;
using System.Collections.Generic;
using System.Text;

namespace LLDSolutions.Splitwise.Models
{
    public class PercentageExpense : Expense
    {
        public PercentageExpense(double amount, User paidBy, Metadata metadata, 
            List<ExpenseDetails> splitInformation) :
           base(amount, paidBy, metadata, splitInformation)
        {
        }

        public override bool Validate()
        {
            return true;

            //A -> 40 
            //B - 40 
            //C -> 30 It is more than 100 %
        }

        //Percentage
    }
}
