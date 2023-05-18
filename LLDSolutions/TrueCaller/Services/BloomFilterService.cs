using LLDSolutions.TrueCaller.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace LLDSolutions.TrueCaller.Services
{
    public class BloomFilterService : IBloomFilterService
    {
        //BloomFilters : ToDo : Ask interviewer whether they are interested in implementing the bloom filters or not ?
        public void AddSpam(string phoneNumber)
        {
            throw new NotImplementedException();
        }

        public bool IsSpam(string phoneNumber)
        {
            throw new NotImplementedException();
        }
    }
}
