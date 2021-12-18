using LLDSolutions.LMS_New.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace LLDSolutions.LMS_New.Interfaces
{
    public interface IFineService
    {
        public double CalculateFine(BookItem boook, long days);
    }
}
