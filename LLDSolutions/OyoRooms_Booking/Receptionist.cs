using LLDSolutions.OyoRooms_Booking;
using System;
using System.Collections.Generic;
using System.Text;

namespace LLDSolutions
{
    public class Receptionist : User
    {
        public Receptionist(string name, DateTime dOB, 
            string cNumber, string email, Address address,
            Sex sex) : base(name, dOB, cNumber, email, address, sex)
        {
        }

        public RoomStatus CheckBooking(List<RoomFacility> roomFacilities)
        {
            return RoomStatus.Available;
        }
    }
}
