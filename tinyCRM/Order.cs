using System;
using System.Collections.Generic;
using System.Text;

namespace tinyCRM
{
   public class Order
    {
       public int OrderId { get; set; }
        public string DeliveryAddress { get; set; }
        public decimal TotalAmount  { get; set; }

        public List<Product> ListOfProducts  { get; set; }





    }
}
