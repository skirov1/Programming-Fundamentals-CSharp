using System;
using System.Collections.Generic;

namespace _04.Orders
{
    class Product
    {
        public Product(double price, int quantity)
        {
            Price = price;
            Quantity = quantity;
        }
        public double Price { get; set; }
        public int Quantity { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Product> orders = new Dictionary<string, Product>();
            List<double> totalPrices = new List<double>();

            while (true)
            {
                string[] data = Console.ReadLine().Split();
                if (data[0] == "buy")
                {
                    break;
                }
                string name = data[0];
                double price = double.Parse(data[1]);
                int quantity = int.Parse(data[2]);

                if (!orders.ContainsKey(name))
                {
                    Product product = new Product(price, quantity);
                    orders.Add(name, product);
                }
                else
                {
                    orders[name].Price = price;
                    orders[name].Quantity += quantity;
                }
            }

            foreach (var order in orders)
            {
                Console.WriteLine($"{order.Key} -> {order.Value.Price * order.Value.Quantity:f2}");
            }
        }
    }
}
