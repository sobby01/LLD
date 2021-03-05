using System;
using System.Collections.Generic;
using System.Text;

namespace LLDSolutions.OyoRooms_Booking.Entities
{
    public class Dish
    {
		private string name;
		public string Name
		{
			get { return name; }
			set { name = value; }
		}

		private string price;
		public string Price
		{
			get { return price; }
			set { price = value; }
		}

		public bool IsAvaialble()
		{
			return true;
		}

	}
}
