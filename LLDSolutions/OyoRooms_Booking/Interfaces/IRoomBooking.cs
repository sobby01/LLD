using LLDSolutions.OyoRooms_Booking.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace LLDSolutions.OyoRooms_Booking.Interfaces
{
    public interface IRoomBooking
    {
        public List<Room> SearchRoom(DateTime startDate, string duration);

        public bool CreateBooking(Room room, User user, Discount discount);

        public BillDetails FetchBill(Room room);
    }
}
