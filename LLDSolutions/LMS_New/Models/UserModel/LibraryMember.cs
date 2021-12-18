using System;
using System.Collections.Generic;
using System.Text;

namespace LLDSolutions.LMS_New.Models.UserModel
{
    public class LibraryMember: SystemUser
    {
        SearchService searchObj;
        int TotalCheckedOutBooks { get; set; }

        BookService issueService;
    }
}
