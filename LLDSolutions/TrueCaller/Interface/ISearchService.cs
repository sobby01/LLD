
using LLDSolutions.TrueCaller.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace LLDSolutions.TrueCaller.Interface
{
    public interface ISearchService
    {
        public User SearchByPhoneNumber(string phoneNumber);
    }
}
