
using LLDSolutions.TrueCaller.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace LLDSolutions.TrueCaller.Interface
{
    public interface IBloomFilterService
    {
        public bool IsSpam(string phoneNumber);

        public void AddSpam(string phoneNumber);
    }
}
