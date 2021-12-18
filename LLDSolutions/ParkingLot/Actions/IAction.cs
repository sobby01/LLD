using System;
using System.Collections.Generic;
using System.Text;

namespace LLDSolutions.ParkingLot.Actions
{
    public interface IAction
    {
        string GetType();

        bool Execute();
    }
}
