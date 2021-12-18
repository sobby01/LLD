using System;
using System.Collections.Generic;
using System.Text;

namespace LLDSolutions.LMS_New.Models
{
    public class Library
    {
        public string Name { get; set; }
        public Address  LibAddress { get; set; }

        public List<BookItem> BookItems { get; set; }
    }
}
