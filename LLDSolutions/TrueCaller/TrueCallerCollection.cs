using LLDSolutions.TrueCaller.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace LLDSolutions.TrueCaller
{
    public class TrueCallerCollection
    {
        private static readonly Lazy<TrueCallerCollection> instance = new Lazy<TrueCallerCollection>( () => new TrueCallerCollection());

        private TrueCallerCollection()
        {

        }

        public static TrueCallerCollection Instance
        {
            get
            {
                return instance.Value;
            }
        }

        //We should be able to distribute this list in disc
        public List<User> UserList { get; private set; }
    }
}
