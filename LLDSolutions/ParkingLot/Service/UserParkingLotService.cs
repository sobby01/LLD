using LLDSolutions.ParkingLot.Actions;
using System;
using System.Collections.Generic;
using System.Text;

namespace LLDSolutions.ParkingLot.Service
{
    public class ParkingLotService
    {
        public UserActions GetService(string carService)
        {
            switch (carService)
            {
                case "Admin":
                    return new AdminParkingLotService();
                case "User":
                    return new UserParkingLotService();
            }
            return null;
        }
    }

    public abstract class UserActions
    {
        public UserActions()
        {
            this.CreateActions();
        }

        public List<IAction> Actions = new List<IAction>();

        public virtual void CreateActions() { }
    }

    public class UserParkingLotService : UserActions
    {
        public override void CreateActions()
        {
            this.Actions.Add(new AssignTicket());
        }

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }

    public class AdminParkingLotService : UserActions
    {
        public override void CreateActions() 
        {
            this.Actions.Add(new AddParkingFloor());
            this.Actions.Add(new AddParkingSpace());
            this.Actions.Add(new RemoveUser());
        }

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
