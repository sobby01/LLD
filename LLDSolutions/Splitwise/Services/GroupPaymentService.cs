using LLDSolutions.Splitwise.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace LLDSolutions.Splitwise.Services
{
    public class GroupPaymentService
    {
        public List<Transaction> GetPaymentGraph(List<Expense> balanceMap, string groupId)
        {
            double totalAmount = 0;// map of the positive and negative values
            //7 Expenses are like equal
            foreach (Expense ex in balanceMap)
            {
                ex.Calculate
            }
            
            //Async implementation from both the services


            //PaymentGraph by Percentrage
            //PaymentGraph

            

            //Heapify concept to implement the sdame logic and every popup will create a transaction


            //A -> 100
            //B -> -200

        }
    }


    public class PercentagePaymentService
    {

    }

    public class E
}
