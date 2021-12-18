using LLDSolutions.LMS_New.Constants;
using System;
using System.Collections.Generic;
using System.Text;

namespace LLDSolutions.LMS_New.Models
{
    public class Book
    {
        public BookFormat BookType { get; set; }

        public List<BookAuthor> Author { get; set; }

        public string Publication { get; set; }

        public string PublishedDate { get; set; }

        private string Title { get; set; }

        private string Language { get; set; }

        public int Copies { get; set; }

        public string UID { get; set; }
    }
}
