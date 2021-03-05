using System;
using System.Collections.Generic;
using System.Text;

namespace LLDSolutions.OyoRooms_Booking
{
    public class Manager : User
    {
        public Manager(string name, DateTime dOB, string cNumber, string email, Address address, Sex sex) : base(name, dOB, cNumber, email, address, sex)
        {
        }
    }
}
