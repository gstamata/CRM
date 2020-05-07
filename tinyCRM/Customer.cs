using System;
using System.Collections.Generic;
using System.Text;

namespace tinyCRM
{
    public class Customer
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Vatnumber { get; set; }
        public string Phone { get; set; }
        public decimal TotalGross { get; set; }
        public List <Order> CustomerOrders { get; set; }

     

        public Customer()
        { }

        public bool IsValidVatNumber(string vatNumber)
        {
            return
                !string.IsNullOrWhiteSpace(vatNumber) && 
                vatNumber.Length == 9;
        }
    }
}
