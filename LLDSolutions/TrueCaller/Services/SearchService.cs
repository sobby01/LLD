using LLDSolutions.TrueCaller.Interface;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using LLDSolutions.TrueCaller.Models;

namespace LLDSolutions.TrueCaller.Services
{
    public class SearchService : ISearchService
    {
        public User SearchByPhoneNumber(string phoneNumber)
        {
            return TrueCallerCollection.Instance.UserList.FirstOrDefault(x => x.PhoneNumber.Equals(phoneNumber, StringComparison.InvariantCultureIgnoreCase));
        }
    }
}
