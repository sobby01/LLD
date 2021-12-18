using System;
using System.Collections.Generic;
using System.Text;

namespace LLDSolutions.LMS
{
    public abstract class Book
    {
        private String ISBN;
        private String title;
        private String subject;
        private String publisher;
        private String language;
        private int numberOfPages;
        private List<User> authors;
    }
}
