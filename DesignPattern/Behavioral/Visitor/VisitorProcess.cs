using DesignPattern.Behavioral.Visitor.Visitor2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Behavioral.Visitor
{
    internal class VisitorProcess
    {
        public void Process() {

            List<IEmployee> employees = new List<IEmployee>
            {
                new EngineeringManager("John Doe", 100000),
                new ProjectManager("Jane Smith", 90000),
                new SoftwareEngineer("Alice Johnson", 80000)
            };

            IVisitor salaryCalculator = new SalaryCalculator();

            foreach (var employee in employees)
            {
                employee.Accept(salaryCalculator);
            }
        }

        public void Process2()
        {
            ItemElement[] items = new ItemElement[]
            {
                new Book(20, "1234"), new Book(100, "5678"),
                new Fruit(10, 2, "Banana"), new Fruit(5, 5, "Apple")
            };

            int total = CalculatePrice(items);
            Console.WriteLine($"Total Cost = {total}");
        }

        private int CalculatePrice(ItemElement[] items)
        {
            IShoppingCartVisitor visitor = new ShoppingCartVisitorImpl();
            int sum = 0;
            foreach (var item in items)
            {
                sum += item.Accept(visitor);
            }
            return sum;
        }
    }
}
