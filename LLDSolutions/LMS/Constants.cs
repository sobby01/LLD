﻿
using System;
using System.Collections.Generic;
using System.Text;

namespace LLDSolutions.LMS
{
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

    public enum BookStatus
    {
        AVAILABLE,
        RESERVED,
        LOANED,
        LOST
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

    public class Address
    {
        private String streetAddress;
        private String city;
        private String state;
        private String zipCode;
        private String country;
    }

    public class Person
    {
        private String name;
        private Address address;
        private String email;
        private String phone;
    }

    public class Constants
    {
        public static int MAX_BOOKS_ISSUED_TO_A_USER = 5;
        public static int MAX_LENDING_DAYS = 10;
    }
}
