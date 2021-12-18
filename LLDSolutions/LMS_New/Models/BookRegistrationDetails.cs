using LLDSolutions.LMS_New.Constants;
using System;
using System.Collections.Generic;
using System.Text;

namespace LLDSolutions.LMS_New.Models
{
    public class BookRegistrationDetails : BookLending
    {
        ReservationStatus Status { get; set; }
    }
}
