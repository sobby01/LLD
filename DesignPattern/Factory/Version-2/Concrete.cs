using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Factory.Version_2
{
    public abstract class Document
    {
        public List<Page> pages = new List<Page>();

        public Document()
        {
            this.CreatePage();
        }

        public virtual void CreatePage()
        {

        }
    }

    public class ConcreteDocument1 : Document
    {
        public override void CreatePage()
        {
            this.pages.Add(new ResumePage());
            this.pages.Add(new HomePage());
        }

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }

    public class ConcreteDocument2 : Document
    {
        public override void CreatePage()
        {
            this.pages.Add(new EducationPage());
            this.pages.Add(new AboutPage());
        }

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
