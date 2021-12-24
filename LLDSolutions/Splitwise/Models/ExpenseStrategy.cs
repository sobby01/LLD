using LLDSolutions.Splitwise.Constants;
using System;
using System.Collections.Generic;
using System.Text;

namespace LLDSolutions.Splitwise.Models
{

    //A(60), B(40), C(30)
    public class ExpenseDetails
    {
        public User UserDetail { get; set; }

        public ExpenseType Type { get; set; }

        public int Percentage { get; set; }

    }
}
