using LLDSolutions.OyoRooms_Booking;
using LLDSolutions.OyoRooms_Booking.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace LLDSolutions
{
    public class Hotel : IHotel
    {
        public Hotel()
        {

        }

        private Guid hotelId;
        public Guid HotelId
        {
            get { return hotelId; }
            set { hotelId = value; }
        }

        private string hotelName;
        public string HotelName
        {
            get { return hotelName; }
            set { hotelName = value; }
        }

        private Address hoteladdress;
        public Address HotelAddress
        {
            get { return hoteladdress; }
            set { hoteladdress = value; }
        }

        private List<Room> rooms;
        public List<Room> Rooms
        {
            get { return rooms; }
            set { rooms = value; }
        }

        private float rating;
        public float Rating
        {
            get { return rating; }
            set { rating = value; }
        }

        private List<HotelFacility> facilities;
        public List<HotelFacility> Facilities
        {
            get { return facilities; }
            set { facilities = value; }
        }

        public List<Room> GetRooms()
        {
            throw new NotImplementedException();
        }
    }
}
