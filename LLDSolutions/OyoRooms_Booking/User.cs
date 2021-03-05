using System;
using System.Collections.Generic;
using System.Text;

namespace LLDSolutions.OyoRooms_Booking
{
    public class User
    {
        public User(string name, DateTime dOB, string cNumber, string email, 
            Address address, Sex sex)
        {
            this.UserID = Guid.NewGuid();
            this.DateOfBirth = dOB;
            this.ContactNumber = cNumber;
            this.EmailId = email;
            this.Address = address;
            this.SexInfo = sex;
        }

        private Address address;
        public Address Address
        {
            get { return address; }
            set { address = value; }
        }

        Guid userId;
        public Guid UserID
        {
            get
            {
                return userId;
            }
            set
            {
                userId = value;
            }
        }

        private string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        private DateTime dateOfBirth;
        public DateTime DateOfBirth
        {
            get { return dateOfBirth; }
            set { dateOfBirth = value; }
        }

        private string contactNumber;
        public string ContactNumber
        {
            get { return contactNumber; }
            set { contactNumber = value; }
        }

        private string emailId;
        public string EmailId
        {
            get { return emailId; }
            set { emailId = value; }
        }

        private Sex sexInfo;
        public Sex SexInfo
        {
            get { return sexInfo; }
            set { sexInfo = value; }
        }
    }
}
