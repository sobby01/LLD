using System;
using System.Collections.Generic;
using System.Text;

namespace LLDSolutions.LMS_New.Constants
{
    public enum BookStatus
    {
        AVAILABLE,
        RESERVED,
        LOST
    }

    public enum BookFormat
    {
        HARDCOVER,
        PAPERBACK,
        AUDIO_BOOK,
        EBOOK,
        NEWSPAPER,
        MAGAZINE,
        JOURNAL
    }

    public enum ReservationStatus
    {
        COMPLETED,
        WAITING,
        PENDING,
        CANCELED,
        NONE
    }

    public enum AccountStatus
    {
        ACTIVE,
        CLOSED,
        CANCELED,
        BLACKLISTED,
        NONE
    }
}
