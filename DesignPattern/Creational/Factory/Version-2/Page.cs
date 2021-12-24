using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Factory.Version_2
{
    public interface Page
    {
        string GetPageType();
        void DoAction();
    }

    public class ResumePage : Page
    {
        public void DoAction()
        {
            throw new NotImplementedException();
        }

        public string GetPageType()
        {
            throw new NotImplementedException();
        }
    }

    public class HomePage : Page
    {
        public void DoAction()
        {
            throw new NotImplementedException();
        }

        public string GetPageType()
        {
            throw new NotImplementedException();
        }
    }

    public class AboutPage : Page
    {
        public void DoAction()
        {
            throw new NotImplementedException();
        }

        public string GetPageType()
        {
            throw new NotImplementedException();
        }
    }

    public class EducationPage : Page
    {
        public void DoAction()
        {
            throw new NotImplementedException();
        }

        public string GetPageType()
        {
            throw new NotImplementedException();
        }
    }
}
