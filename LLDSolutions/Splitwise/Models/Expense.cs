using System;
using System.Collections.Generic;
using System.Text;

namespace LLDSolutions.Splitwise.Models
{
    public abstract class Expense
    {
        public Expense(double amount, User paidBy, Metadata metadata, List<ExpenseDetails> splitInformation, string groupId)
        {
            this.Amount = amount;
            this.ExpensePaidBy = paidBy;
            this.ExpenseMetadata = metadata;
            this.SplitInformation = splitInformation;

            //I should check whether this number of users already a group or not ?
            this.ExpenseId = Guid.NewGuid().ToString();
        }

        public string ExpenseId { get; private set; }

        public double Amount { get; private set; }

        public User ExpensePaidBy { get; private set; }

        public Metadata ExpenseMetadata { get; private set; }

        public List<ExpenseDetails> SplitInformation { get; private set; }



        public abstract bool Validate();
    }
}
