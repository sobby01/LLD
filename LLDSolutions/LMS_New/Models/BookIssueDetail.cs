using System;
using System.Collections.Generic;
using System.Text;

namespace LLDSolutions.LMS_New.Models
{
    public class BookIssueDetail : BookLending
    {
        public DateTime DueDate { get; set; }
    }
}
