using System;

namespace _05.Orders
{
    class Program
    {
        static void Main(string[] args)
        {
            CalculatePrice(Console.ReadLine(), int.Parse(Console.ReadLine()));
        }
        static void CalculatePrice(string product, int quantity)
        {
            double price = 0;
            switch (product)
            {
                case "coffee":
                    price = 1.50 * quantity;
                    break;
                case "water":
                    price = quantity;
                    break;
                case "coke":
                    price = 1.40 * quantity;
                    break;
                case "snacks":
                    price = 2 * quantity;
                    break;
            }
            Console.WriteLine($"{price:f2}");
        }
    }
}
