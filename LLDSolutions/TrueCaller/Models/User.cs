using System;
using System.Collections.Generic;
using System.Text;

namespace LLDSolutions.TrueCaller.Models
{
    public class User
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public Address AddressInfo { get; set; }

        public string PhoneNumber { get; set; }

        public string Email { get; set; }

        public List<SocialProfile> ProfileInfo { get; set; }

        public List<UserBlockList> BlockeduserList { get; set; }

        public bool IsSpam { get; set; }

        public string GetName()
        {
            return FirstName + " " + LastName;
        }
    }
}
