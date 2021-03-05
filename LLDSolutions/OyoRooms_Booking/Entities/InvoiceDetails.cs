using System;
using System.Collections.Generic;
using System.Text;

namespace LLDSolutions.OyoRooms_Booking.Entities
{
    public class InvoiceDetails
    {
		private double amount;
		public double Amount
		{
			get { return amount; }
			set { amount = value; }
		}

		private double discountPercentage;
		public double Discount
		{
			get { return discountPercentage; }
			set { discountPercentage = value; }
		}


	}
}
