using System;
using System.Collections.Generic;
using System.Text;

namespace LLDSolutions.OyoRooms_Booking.Interfaces
{
    public interface IRoom
    {
        public bool IsRoomAvaialble();

        public bool CheckIn();
        
        public bool CheckOut();
    }
}
