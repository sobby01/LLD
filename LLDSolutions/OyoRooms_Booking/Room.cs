using LLDSolutions.OyoRooms_Booking.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace LLDSolutions.OyoRooms_Booking
{
    public class Room : IRoom
    {
        public Room()
        {
            
        }

        private Guid roomId;
        public Guid RoomId
        {
            get { return roomId; }
            set { roomId = value; }
        }

        private Guid hotelId;
        public Guid HotelId
        {
            get { return hotelId; }
            set { hotelId = value; }
        }

        private RoomType roomType;
        public RoomType RoomType
        {
            get { return roomType; }
            set { roomType = value; }
        }
        
        private RoomStatus roomStatus;
        public RoomStatus RoomStatus
        {
            get { return roomStatus; }
            set { roomStatus = value; }
        }

        private List<RoomFacility> facilities;
        public List<RoomFacility> Facilities
        {
            get { return facilities; }
            set { facilities = value; }
        }

        public bool IsRoomAvaialble()
        {
            return true;
        }

        public bool CheckIn()
        {
            return true;
        }

        public bool CheckOut()
        {
            return true;
        }
    }
}
