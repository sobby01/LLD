using LLDSolutions.LMS_New.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace LLDSolutions.LMS_New.Interfaces
{
    public interface IBookRegistrationService
    {
        public BookIssueDetail IssueBook(BookItem book, Person user);

        public BookRegistrationDetails BookRegistration(BookItem book);

        public BookIssueDetail RenewBook(BookItem book);

        public void ReturnBook(BookItem book, Person user);

    }
}
