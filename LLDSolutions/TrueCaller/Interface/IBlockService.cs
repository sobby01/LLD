using LLDSolutions.TrueCaller.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace LLDSolutions.TrueCaller.Interface
{
    public interface IBlockService
    {
        public bool BlockPhoneNumber(string phoneNumber, string BlockerPhoneNumber);

        public List<string> GetBlockedContacts();

        public List<string> GetBlockedContacts(User userInfo);

        public bool RemoveBlockedNumber(string phoneNumber);

        public bool RemoveBlockedNumber(string phoneNumber, string blokerPhoneNumber);
    }
}
