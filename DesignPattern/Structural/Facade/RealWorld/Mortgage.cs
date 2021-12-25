using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Structural.Facade
{
    public class Mortgage
    {
        Bank bank = new Bank();
        Loan loan = new Loan();
        Credit credit = new Credit();

        public bool IsEligible(Customer c, int amount)
        {
            Console.WriteLine("{0} applies for {1:C} loan\n", c.Name, amount);
            bool eligible = true;

            if (!bank.HasSavings(c))
            {
                eligible = false;
            }
            else if (!loan.HasNoBadLoans(c))
            {
                eligible = false;
            }
            else if (!credit.HasGoodCredit(c))
            {
                eligible = false;
            }
            return eligible;
        }
    }

    public class TestFacade
    {
        public void Test()
        {
            Mortgage mortgage = new Mortgage();
            
            Customer customer = new Customer("Saurabh Singh");
            
            bool eligible = mortgage.IsEligible(customer, 10000);

            Console.WriteLine("\n" + customer.Name + " loan has been " + (eligible ? "Approved" : "Rejected"));
            
            Console.ReadKey();
        }
    }
}
