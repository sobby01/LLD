using System;
using System.Collections.Generic;
using System.Text;

namespace LLDSolutions.BookMyShow.Models
{
    public class Address
    {
        public string Street { get; set; }

        public int PinCode { get; set; }

        public string City { get; set; }

        public string State { get; set; }

        public string Country { get; set; }
    }
}
