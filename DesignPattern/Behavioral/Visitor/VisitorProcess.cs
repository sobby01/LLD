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
    }
}
