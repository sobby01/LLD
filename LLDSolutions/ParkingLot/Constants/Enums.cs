using System;
using System.Collections.Generic;
using System.Text;

namespace LLDSolutions.ParkingLot.Constants
{
    public enum VehicleType
    {
        CAR = 0,
        ELECTRICCAR = 1,
        BIKE =2,
        THREEWHEELER =3
    }

    public enum ParkingSlotType
    {
        HANDICAPPED = 0,
        COMPACT = 1,
        LARGE = 2,
        BIKE = 3,
        ELECTRIC =4
    }

    public enum ParkingTicketStatus
    {
        ACTIVE = 0,
        PAID = 1,
        LOST = 2
    }
}
