using System;
using System.Collections.Generic;
using System.Text;

namespace LLDSolutions.LMS
{
    public class User : Account
    {
        public override bool ResetPassword()
        {
            throw new NotImplementedException();
        }

        private DateTime dateOfMembership;
        private int totalBooksCheckedout;

        public bool IsBlocked { get; set; }

        public int getTotalBooksCheckedout() { return totalBooksCheckedout; }

        public bool ReserveBookItem(BookItem bookItem)
        {
            return true;
        }

        private void incrementTotalBooksCheckedout()
        {
            totalBooksCheckedout++;
        }

        private void decrementTotalBooksCheckedout()
        {
            totalBooksCheckedout--;
        }

        public bool checkoutBookItem(BookItem bookItem)
        {
            if (getTotalBooksCheckedout() >= Constants.MAX_BOOKS_ISSUED_TO_A_USER)
            {
                //ShowError("The user has already checked-out maximum number of books");
                return false;
            }
            BookReservation bookReservation = BookReservation.fetchReservationDetails(bookItem.getBarcode());
            if (bookReservation != null && bookReservation.GetMemberId() != this.getId())
            {
                //book item has a pending reservation from another user
                //ShowError("This book is reserved by another member");
                return false;
            }
            else if (bookReservation != null)
            {
                // book item has a pending reservation from the give member, update it
                bookReservation.updateStatus(ReservationStatus.COMPLETED);
            }

            if (!bookItem.checkout(this.getId()))
            {
                return false;
            }

            this.incrementTotalBooksCheckedout();
            return true;
        }

        private string getId()
        {
            throw new NotImplementedException();
        }

        private void checkForFine(String bookItemBarcode)
        {
            BookLending bookLending = BookLending.fetchLendingDetails(bookItemBarcode);
            DateTime dueDate = bookLending.getDueDate();

            DateTime today = new DateTime();
            // check if the book has been returned within the due date
            if (today.CompareTo(dueDate) > 0)
            {
                string memberId = string.Empty;//Get the m
                TimeSpan diff = today.Subtract(dueDate);
                Fine.collectFine(memberId, diff.Days);
            }
        }

        public void ReturnBookItem(BookItem bookItem)
        {
            this.checkForFine(bookItem.getBarcode());
            BookReservation bookReservation = BookReservation.fetchReservationDetails(bookItem.getBarcode());
            if (bookReservation != null)
            {
                // book item has a pending reservation
                bookItem.updateBookItemStatus(BookStatus.RESERVED);
                bookReservation.sendBookAvailableNotification();
            }
            bookItem.updateBookItemStatus(BookStatus.AVAILABLE);
        }

        public bool renewBookItem(BookItem bookItem)
        {
            this.checkForFine(bookItem.getBarcode());
            BookReservation bookReservation = BookReservation.fetchReservationDetails(bookItem.getBarcode());
            // check if this book item has a pending reservation from another member
            if (bookReservation == null || bookReservation.getMemberId() == getMemberId())
            {
                if (bookReservation != null)
                {
                    // book item has a pending reservation from this member
                    bookReservation.updateStatus(ReservationStatus.COMPLETED);
                }
            }
            else
            {
                //ShowError("This book is reserved by another member");
                decrementTotalBooksCheckedout();
                bookItem.updateBookItemState(BookStatus.RESERVED);
                bookReservation.sendBookAvailableNotification();
                return false;
            }

            BookLending.lendBook(bookItem.getBarCode(), this.getMemberId());
            bookItem.updateDueDate(DateTime.Now.AddDays(Constants.MAX_LENDING_DAYS));
            return true;
        }

        private string getMemberId()
        {
            throw new NotImplementedException();
        }
    }
}
