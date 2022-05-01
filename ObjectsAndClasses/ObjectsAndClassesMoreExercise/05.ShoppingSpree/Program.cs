using System;
using System.Collections.Generic;

namespace _05.ShoppingSpree
{
    class Person
    {
        public string Name { get; set; }
        public int Money { get; set; }

        public List<Product> products = new List<Product>();
    }
    class Product
    {
        public string Name { get; set; }
        public int Cost { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> people = new List<Person>();

        }
    }
}
