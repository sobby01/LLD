using System;
using System.Collections.Generic;
using System.Text;

namespace LLDSolutions.LMS
{
    public class BookItem : Book
    {
        private String barcode;
        private bool isReferenceOnly;
        private DateTime borrowed;
        private DateTime dueDate;
        private double price;
        private BookFormat format;
        private BookStatus status;
        private DateTime dateOfPurchase;
        private DateTime publicationDate;
        private Rack placedAt;

        public bool checkout(String memberId)
        {
            if (this.GetIsReferenceOnly())
            {
                //"This book is Reference only and can't be issued";
                return false;
            }
            if (!BookLending.lendBook(this.getBarCode(), memberId))
            {
                return false;
            }
            this.updateBookItemStatus(BookStatus.LOANED);
            return true;
        }

        public bool GetIsReferenceOnly()
        {
            return true;
        }

        public string getBarCode()
        {
            StringBuilder strbuilder = new StringBuilder();
            Random random = new Random();

            for (int i = 0; i < 8; i++)
            {
                // Generate floating point numbers
                double myFloat = random.NextDouble();
                // Generate the char using below logic
                var myChar = Convert.ToChar(Convert.ToInt32(Math.Floor(25 * myFloat) + 65));
                strbuilder.Append(myChar);
            }

            return strbuilder.ToString();
        }

        internal string getBarcode()
        {
            throw new NotImplementedException();
        }

        public void updateBookItemStatus(BookStatus status)
        {

        }

        internal void updateBookItemState(BookStatus rESERVED)
        {
            throw new NotImplementedException();
        }

        internal void updateDueDate(DateTime dueDate)
        {
            throw new NotImplementedException();
        }
    }
}
