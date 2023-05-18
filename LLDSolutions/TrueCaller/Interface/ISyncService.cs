using System;
using System.Collections.Generic;
using System.Text;

namespace LLDSolutions.TrueCaller.Interface
{
    //This will be a background service which will update the contacts in the batches
    public interface ISyncService
    {
        //One is getting the phone number and the name from the user mobile number
        //then it will search in the global db
        //user -> it's list of contact in the database
        //global list of contacts : if a duplicate phone number is already there -> list of names (as per the priority order)
        //phone number with list <names> 

    }
}
