using System;

namespace Methods_Lab
{
    class Program
    {
        static void Main(string[] args)
        {
            CheckNumber(int.Parse(Console.ReadLine()));
        }
        static void CheckNumber(int number)
        {
            if (number > 0)
            {
                Console.WriteLine($"The number {number} is positive.");
            }
            else if (number<0)
            {
                Console.WriteLine($"The number {number} is negative.");
            }
            else
            {
                Console.WriteLine("The number 0 is zero.");
            }
        }
    }
}
