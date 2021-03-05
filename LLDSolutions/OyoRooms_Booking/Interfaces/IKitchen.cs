using LLDSolutions.OyoRooms_Booking.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace LLDSolutions.OyoRooms_Booking.Interfaces
{
    public interface IKitchen
    {
        public bool IsDishAvailable(Dish dishInfo);

        public bool OrderFood(Room room);

        public InvoiceDetails GetKitechnBill(Room room);
    }
}
