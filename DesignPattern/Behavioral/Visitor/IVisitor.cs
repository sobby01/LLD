using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Behavioral.Visitor
{
    public interface IVisitor
    {
        void Visit(EngineeringManager manager);
        void Visit(ProjectManager manager);
        void Visit(SoftwareEngineer engineer);
    }
}
