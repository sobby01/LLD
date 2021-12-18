using LLDSolutions.LMS_New.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace LLDSolutions.LMS_New.Models.UserModel
{
    public class Librarian : SystemUser
    {
        SearchService serachObject;
        BookService bookService;
        FineService fineService;

        public void AddBookItem(BookItem book) { }

        public void DeleteBookItem(string barCode) { }

        public void EditBookItem(BookItem book) { }


    }
}
