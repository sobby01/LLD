using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Behavioral.Visitor
{
    public interface IEmployee
    {
        void Accept(IVisitor visitor);
        string Name { get; }
        double BaseSalary { get; }
    }

    public class EngineeringManager : IEmployee
    {
        public EngineeringManager(string name, double baseSalary)
        {
            Name = name;
            BaseSalary = baseSalary;
        }

        public string Name { get; private set; }
        public double BaseSalary { get; private set; }

        public void Accept(IVisitor visitor)
        {
            visitor.Visit(this);
        }
    }

    public class ProjectManager : IEmployee
    {
        public ProjectManager(string name, double baseSalary)
        {
            Name = name;
            BaseSalary = baseSalary;
        }

        public string Name { get; private set; }
        public double BaseSalary { get; private set; }

        public void Accept(IVisitor visitor)
        {
            visitor.Visit(this);
        }
    }

    public class SoftwareEngineer : IEmployee
    {
        public SoftwareEngineer(string name, double baseSalary)
        {
            Name = name;
            BaseSalary = baseSalary;
        }

        public string Name { get; private set; }
        public double BaseSalary { get; private set; }

        public void Accept(IVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}
