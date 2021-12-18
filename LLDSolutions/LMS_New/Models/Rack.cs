using System;
using System.Collections.Generic;
using System.Text;

namespace LLDSolutions.LMS_New.Models
{
    public class Rack
    {
        public Rack(int rackRows, int rackColumns)
        {
            RackRows = rackRows;
            RackColumns = rackColumns;
            RackArray = new BookItemCollection[rackRows, RackColumns];
        }

        public int RackRows { get; private set; }
        public int RackColumns { get; private set; }
        public BookItemCollection[,] RackArray { get; private set; }
    }
}
