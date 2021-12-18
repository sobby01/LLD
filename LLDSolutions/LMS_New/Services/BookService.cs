using LLDSolutions.LMS_New.Interfaces;
using LLDSolutions.LMS_New.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace LLDSolutions.LMS_New
{
    public class BookService : IBookRegistrationService
    {
        public BookRegistrationDetails BookRegistration(BookItem book)
        {
            throw new NotImplementedException();
        }

        public BookIssueDetail IssueBook(BookItem book, Person user)
        {
            throw new NotImplementedException();
        }

        public BookIssueDetail RenewBook(BookItem book)
        {
            throw new NotImplementedException();
        }

        public void ReturnBook(BookItem book, Person user)
        {
            throw new NotImplementedException();
        }
    }
}
