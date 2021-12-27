using System;
using System.Collections.Generic;
using System.Text;

namespace LLDSolutions.VendingMachine.Models
{
    public class Product
    {
        public string ProductId { get; set; }

        public ProductType Type { get; set; }

        public string Name { get; set; }

        public Brand BrandName { get; set; }

        public int Price { get; set; }
    }
}
