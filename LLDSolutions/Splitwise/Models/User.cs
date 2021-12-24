using System;
using System.Collections.Generic;
using System.Text;

namespace LLDSolutions.Splitwise.Models
{
    public class User
    {
        public string Name { get; set; }

        public string UserId { get; set; }

        public string Password { get; set; } //Encryption //Hashed

        public string Email { get; set; }

        public string Phone { get; set; }
    }
}
