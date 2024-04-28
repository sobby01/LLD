using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Behavioral.Visitor
{
    public class SalaryCalculator : IVisitor
    {
        public void Visit(EngineeringManager manager)
        {
            double bonus = manager.BaseSalary * 0.2;
            Console.WriteLine($"{manager.Name} (Engineering Manager): Total Salary = ${manager.BaseSalary + bonus}");
        }

        public void Visit(ProjectManager manager)
        {
            double bonus = manager.BaseSalary * 0.15;
            Console.WriteLine($"{manager.Name} (Project Manager): Total Salary = ${manager.BaseSalary + bonus}");
        }

        public void Visit(SoftwareEngineer engineer)
        {
            double bonus = engineer.BaseSalary * 0.1;
            Console.WriteLine($"{engineer.Name} (Software Engineer): Total Salary = ${engineer.BaseSalary + bonus}");
        }
    }
}
