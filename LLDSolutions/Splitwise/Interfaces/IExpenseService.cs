using LLDSolutions.Splitwise.Constants;
using LLDSolutions.Splitwise.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace LLDSolutions.Splitwise.Interfaces
{
    public interface IExpenseService
    {
        //Add Expense
        //Edit Expense
        //Settle Expense

        Expense AddExpense(ExpenseType type, User expensePaidBy, Metadata metadata, double amount, List<ExpenseDetails> expenseDetails);

        //GetExpense id ->

        Expense EditExpense(string expenseId, Metadata metadata, double Amount);

        List<Expense> GetAllExpenses(User userInfo);

        //PaymentGraph SettleExpense(string expenseId);
 
    }
}
