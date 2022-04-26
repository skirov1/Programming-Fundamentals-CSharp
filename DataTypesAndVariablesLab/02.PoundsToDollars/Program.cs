using System;

namespace _02.PoundsToDollars
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal GBP = decimal.Parse(Console.ReadLine());
            decimal USD = GBP * (decimal)1.31;
            Console.WriteLine($"{USD:f3}");
        }
    }
}
