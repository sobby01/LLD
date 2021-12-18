using System;
using System.Collections.Generic;
using System.Text;

namespace LLDSolutions.LMS
{
    public abstract class Account
    {
        private String id;
        private String password;
        private AccountStatus status;
        private Person person;

        public abstract bool ResetPassword();
    }
}
