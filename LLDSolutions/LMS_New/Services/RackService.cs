using LLDSolutions.LMS_New.Interfaces;
using LLDSolutions.LMS_New.Models;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace LLDSolutions.LMS_New
{
    public sealed class RackService : IRackService
    {
        private static readonly Lazy<RackService> singleInstance = 
            new Lazy<RackService>(() => new RackService()); //private static Singleton singleInstance = null;  

        public static RackService SingleInstance
        {
            get
            {
                return singleInstance.Value;
            }
        }

        public Dictionary<string, Point> BookRackMapper;
        Rack rack;
        public RackService()
        {
            rack = new Rack(10, 10);
            BookRackMapper = new Dictionary<string, Point>();
        }

        public void AssignTheRack(string barCode)
        {
            //Find the empty location and put all the copies of the Book.
            int copies = 5;// Get the copes of the barcode
            Point position = GetTheEmptyPosition();
            rack.RackArray[position.X, position.Y] = new BookItemCollection()
            {
                BarCode = barCode,
                NoOfCopies = copies
            };
            BookRackMapper.Add(barCode, position);
        }

        private Point GetTheEmptyPosition()
        {
            //Find the position and return
            return new Point(0, 0);
        }

        public Point GetTheBookRack(string barCode)
        {
            Point position;

            BookRackMapper.TryGetValue(barCode, out position);

            return position;
        }
    }
}
