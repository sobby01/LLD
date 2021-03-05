using LLDSolutions.OyoRooms_Booking.Entities;
using LLDSolutions.OyoRooms_Booking.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace LLDSolutions.OyoRooms_Booking
{
    public class RoomBooking : IRoomBooking
    {
        public bool CreateBooking(Room room, User user, Discount discount)
        {
            throw new NotImplementedException();
        }

        public BillDetails FetchBill(Room room)
        {
            throw new NotImplementedException();
        }

        public List<Room> SearchRoom(DateTime startDate, string duration)
        {
            throw new NotImplementedException();
        }
    }
}
