using System;
using System.Collections.Generic;
using System.Text;

namespace LLDSolutions.RateLimiting
{
    public class TokenBucket : IRateLimiter
    {
        public bool GrantAccess()
        {
            return true;
        }
    }
}
