using System;
using System.Collections.Generic;
using System.Text;

namespace LLDSolutions.LMS_New.Models
{
    public class BookLending
    {
        public BookItem Book { get; set; }

        public DateTime StartDate { get; set; }

        public Person User { get; set; }
    }
}
