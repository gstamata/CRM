using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;


namespace tinyCRM
{
    public class Program
    {
        static void Main(string[] args)
        {
            string[] productsFile;
            try
            {
                productsFile = File.ReadAllLines("Product.csv");
            }
            catch (Exception)
            {
                return;
            }
            if (productsFile.Length == 0)
            {
                return;
            }
            var productList = new List<Product>();
            for (var i = 0; i < productsFile.Length; i++)
            {
                var values = productsFile[i].Split(';');
                var productId = values[0];

                var l = productList.Where(product => product.ProductId.Equals(productId)); //arrow functions
                if (l.Count() > 0)
                {
                    continue;
                }
                var product = new Product()
                {
                    ProductId = values[0],
                    Name = values[1],
                    Description = values[2],
                    Price = GetRandomPrice()
                };
                productList.Add(product);

                foreach (var p in productList)
                {
                    //Console.WriteLine($"{p.ProductId} {p.Name} {p.Price}");
                }

            }

            static decimal GetRandomPrice()
            {
                var random = new Random();
                var value = Math.Round(random.NextDouble() * 100, 2);
                return (decimal)value;
            }

            //create 2 customers from a customerLIst
            var customer = new List<Customer>();

            var customer1 = new Customer();
            customer1.FirstName = "Mema";
            customer1.LastName = "Stamataki";
            customer1.Vatnumber = "123456789";
            customer.Add(customer1);

            var customer2 = new Customer();
            customer2.FirstName = "George";
            customer2.LastName = "Damiris";
            customer2.Vatnumber = "987456123";
            customer.Add(customer2);

            var order1 = new Order();
            var order2 = new Order();

            for (var or = 0; or < 10; or++)
            {
                var product = new List<Product>();
                var random = new Random();
                int value = random.Next(1, product.Count);
                order1.ListOfProducts.Add(product.ElementAt(value));

                var value2 = random.Next(1, product.Count());
               order2.ListOfProducts.Add(product.ElementAt(value2));

            }

            foreach (var item in order1.ListOfProducts)
                {
                   Console.WriteLine($"Order 1: {item.Name} and price: {item.Price}");
                   order1.TotalAmount += item.Price;
               }
                     customer1.CustomerOrders.Add(order1);            
                     Console.WriteLine();

            foreach (var item in order2.ListOfProducts)
               {
                   Console.WriteLine($"Order 2: {item.Name} and price: {item.Price}");
                   order2.TotalAmount += item.Price;
                }

                    customer2.CustomerOrders.Add(order2); 
                    Console.WriteLine();
        }


    }
}

