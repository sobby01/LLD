using LLDSolutions.LMS_New.Constants;
using LLDSolutions.LMS_New.Interfaces;
using LLDSolutions.LMS_New.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace LLDSolutions.LMS_New
{
    public class SearchService : ISearchService
    {
        public List<BookItem> GetBookByAuthor(string author)
        {
            throw new NotImplementedException();
        }

        public List<BookItem> GetBookByPublicationDate(DateTime date)
        {
            throw new NotImplementedException();
        }

        public List<BookItem> GetBookByTitle(string title)
        {
            throw new NotImplementedException();
        }

        public List<BookItem> GetBookByType(BookFormat bookType)
        {
            throw new NotImplementedException();
        }
    }
}
