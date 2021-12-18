using LLDSolutions.LMS_New.Constants;
using LLDSolutions.LMS_New.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace LLDSolutions.LMS_New.Interfaces
{
    public interface ISearchService
    {
        public List<BookItem> GetBookByTitle(string title);

        public List<BookItem> GetBookByAuthor(string author);

        public List<BookItem> GetBookByType(BookFormat bookType);

        public List<BookItem> GetBookByPublicationDate(DateTime date);
    }
}
