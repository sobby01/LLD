using System;
using System.Collections.Generic;
using System.Text;

namespace LLDSolutions.LMS
{
    public class BookLending
    {
        private DateTime creationDate;
        private DateTime dueDate;
        private DateTime returnDate;
        private String bookItemBarcode;
        private String memberId;

        public static bool lendBook(String barcode, String memberId)
        {
            return true;
        }
        public static  BookLending fetchLendingDetails(String barcode)
        {
            return new BookLending();
        }

        internal DateTime getDueDate()
        {
            throw new NotImplementedException();
        }

        internal string getMemberId()
        {
            return memberId;
        }
    }
}
