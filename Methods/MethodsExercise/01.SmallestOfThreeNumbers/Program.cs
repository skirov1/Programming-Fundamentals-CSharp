using System;

namespace _01.SmallestOfThreeNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            FindSmallestNumber(a, b, c);
        }              
        static void FindSmallestNumber(int a, int b, int c)
        {
            Console.WriteLine(Math.Min(a, Math.Min(b, c)));
        }
    }
}
