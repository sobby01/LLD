using LLDSolutions.LMS_New.Models;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace LLDSolutions.LMS_New.Interfaces
{
    public interface IRackService
    {
        public Point GetTheBookRack(string barCode);

        public void AssignTheRack(string barCode);
    }
}
