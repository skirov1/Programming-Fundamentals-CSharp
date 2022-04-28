using System;

namespace _05.AddAndSubtract
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            int sum = FirstTwoIntegersSum(a, b);
            Console.WriteLine(SubtractThirdInteger(sum, c));
        }
        static int FirstTwoIntegersSum(int a, int b)
        {
            return a + b;
        }
        static int SubtractThirdInteger(int sum, int c)
        {
            return sum - c;
        }
    }
}
