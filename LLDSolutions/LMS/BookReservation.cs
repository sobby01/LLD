using System;
using System.Collections.Generic;
using System.Text;

namespace LLDSolutions.LMS
{
    public class BookReservation
    {
        private DateTime creationDate;
        private ReservationStatus status;
        private String bookItemBarcode;
        private String memberId;

        public static BookReservation fetchReservationDetails(String barcode)
        {
            return new BookReservation();
        }

        public string GetMemberId()
        {
            return memberId;
        }

        public string GetBookItemBarcode()
        {
            return bookItemBarcode;
        }

        internal void updateStatus(object cOMPLETED)
        {
            throw new NotImplementedException();
        }

        internal string getMemberId()
        {
            throw new NotImplementedException();
        }

        internal void sendBookAvailableNotification()
        {
            throw new NotImplementedException();
        }
    }
}
