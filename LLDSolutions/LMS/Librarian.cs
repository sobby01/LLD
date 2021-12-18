using System;
using System.Collections.Generic;
using System.Text;

namespace LLDSolutions.LMS
{
    public class Librarian : Account
    {
        public override bool ResetPassword()
        {
            throw new NotImplementedException();
        }

        public bool AddBookItem(BookItem bookItem)
        {
            return true;
        }

        public bool BlockMember(User member) {

            return true;
        }

        public bool UnBlockMember(User member)
        {
            return false;
        }
    }
}
