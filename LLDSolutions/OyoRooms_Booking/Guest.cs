using LLDSolutions.OyoRooms_Booking;
using System;
using System.Collections.Generic;
using System.Text;

namespace LLDSolutions
{
    public class Guest : User
    {
        public Guest(string name, DateTime dOB, string cNumber, string email, Address address, Sex sex) : base(name, dOB, cNumber, email, address, sex)
        {
        }

        public BookingStatus DoBooking()
        {
            return BookingStatus.Confirmed;
        }
    }
}
