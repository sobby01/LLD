using System;
using System.Collections.Generic;
using System.Text;

namespace LLDSolutions.LMS_New.Models
{
    public class Person
    {
        public string Name { get; set; }

        public string Address { get; set; }

        public string Email { get; set; }

        public string Phone { get; set; }
    }

    public class SystemUser : Person
    {
        public string AccountId { get; set; }
    }
}
  