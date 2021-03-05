using System;
using System.Collections.Generic;
using System.Text;

namespace LLDSolutions
{
    public enum BookingStatus
    {
        Requested = 0,
        Pending= 1,
        Confirmed=2,
        Checked_In = 3,
        Cancelled=4,
        Checked_Out = 5
    }

    public enum Sex
    {
        Male = 0,
        Female =1,
        Other = 2
    }

    public enum RoomStatus
    {
        Available = 0,
        Reserved = 1,
        Occupied = 2,
        Other =3
    }

    public enum RoomType
    {
        SINGLE =0,
        DOUBLE =1,
        TRIPLE =2
    }

    public enum PaymentStatus
    {
        PAID = 0,
        UNPAID = 1,
        Partial = 2
    }

    public enum HotelFacility
    {
        LIFT = 0,
        POWER_BACKUP = 1,
        BREAKFAST_FREE = 3,
        SWIMMING_POOL = 4
    }

    public enum RoomFacility
    {
        Fridge = 0,
        Jacuzzi = 1,
        Iron = 3,
        Hot_Water_Kettle = 4
    }
}
