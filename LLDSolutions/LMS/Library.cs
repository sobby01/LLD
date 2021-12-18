using System;
using System.Collections.Generic;
using System.Text;

namespace LLDSolutions.LMS
{
    public class Library
    {
        public string Name { get; set; }

        public string Address { get; set; }

        public List<User> LibraryUsers { get; set; }
    }
}
