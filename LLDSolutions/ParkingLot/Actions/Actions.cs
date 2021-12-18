using System;
using System.Collections.Generic;
using System.Text;

namespace LLDSolutions.ParkingLot.Actions
{
    public class AssignTicket : IAction
    {
        public bool Execute()
        {
            throw new NotImplementedException();
        }

        string IAction.GetType()
        {
            return "AssignTicket";
        }
    }

    public class AddParkingFloor : IAction
    {
        public bool Execute()
        {
            throw new NotImplementedException();
        }

        string IAction.GetType()
        {
            return "AddParkingFloor";
        }
    }

    public class AddParkingSpace : IAction
    {
        public bool Execute()
        {
            throw new NotImplementedException();
        }

        string IAction.GetType()
        {
            return "AddParkingSpace";
        }
    }

    public class RemoveUser : IAction
    {
        public bool Execute()
        {
            throw new NotImplementedException();
        }

        string IAction.GetType()
        {
            return "RemoveUser";
        }
    }
}
