using System;
using System.Collections.Generic;
using System.Text;

namespace LLDSolutions.LMS_New.Models
{
    public class BookItem : Book
    {
        public bool IsReference { get; set; }

        public double Price { get; set; }

        public string BarCode { get; set; }

        public BookingStatus Status { get; set; }

        public DateTime DateOfpurchase { get; set; }

        public DateTime BorrowedDate { get; set; }

        public DateTime DueDate { get; set; }


    }

    public class BookItemCollection
    {
        public string BarCode { get; set; }

        public int NoOfCopies { get; set; }
    }

}
