using System;
using System.Collections.Generic;
using System.Text;

namespace LLDSolutions.LMS
{
    public interface Search
    {
        public List<Book> searchByTitle(String title);
        public List<Book> searchByAuthor(String author);
        public List<Book> searchBySubject(String subject);
        public List<Book> searchByPubDate(DateTime publishDate);
    }

    public class Catalog : Search
    {
        private Dictionary<String, List<Book>> bookTitles;
        private Dictionary<String, List<Book>> bookAuthors;
        private Dictionary<String, List<Book>> bookSubjects;
        private Dictionary<String, List<Book>> bookPublicationDates;

        public List<Book> searchByTitle(String query)
        {
            // return all books containing the string query in their title.
            bookTitles.TryGetValue(query, out List<Book> titles);
            return titles;
        }

        public List<Book> searchByAuthor(String query)
        {
            // return all books containing the string query in their author's name.

            bookAuthors.TryGetValue(query, out List<Book> authors);
            return authors;
        }

        public List<Book> searchBySubject(string subject)
        {
            throw new NotImplementedException();
        }

        public List<Book> searchByPubDate(DateTime publishDate)
        {
            throw new NotImplementedException();
        }
    }
}
