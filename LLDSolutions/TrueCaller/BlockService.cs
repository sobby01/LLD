using LLDSolutions.TrueCaller.Interface;
using LLDSolutions.TrueCaller.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace LLDSolutions.TrueCaller
{
    public class BlockService : IBlockService
    {
        ISearchService SearchService { get; set; }
        public BlockService(ISearchService searchService)
        {
            SearchService = searchService;
        }

        public bool BlockPhoneNumber(string phoneNumber, string BlockerPhoneNumber)
        {
            //Get me the user from the mobile Number
            throw new NotImplementedException();
        }

        public List<string> GetBlockedContacts(string BlockerPhoneNumber)
        {
            throw new NotImplementedException();
        }

        public List<string> GetBlockedContacts(User userInfo)
        {
            throw new NotImplementedException();
        }


        public bool RemoveBlockedNumber(string phoneNumber, string blokerPhoneNumber)
        {
            throw new NotImplementedException();
        }

        public List<string> GetBlockedContacts()
        {
            throw new NotImplementedException();
        }

        public bool RemoveBlockedNumber(string phoneNumber)
        {
            throw new NotImplementedException();
        }
    }
}
