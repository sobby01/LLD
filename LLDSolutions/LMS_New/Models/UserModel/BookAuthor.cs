using System;
using System.Collections.Generic;
using System.Text;

namespace LLDSolutions.LMS_New.Models
{
    public class BookAuthor : Person
    {
        public string Name { get; set; }

        public Address AuthorAddress { get; set; }

        public string Email { get; set; }

        List<Book> PublishedBooks { get; set; }
    }
}
