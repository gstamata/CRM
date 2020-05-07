using System;
using System.Collections.Generic;
using System.Text;

namespace tinyCRM
{
   public class Product
    {
        public string ProductId { get; set; }
        public string Description { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public List<Order> Orders { get; set; }
    }
}
