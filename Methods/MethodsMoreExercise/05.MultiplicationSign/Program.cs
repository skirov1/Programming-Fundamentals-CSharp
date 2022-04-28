using System;

namespace _05.MultiplicationSign
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());
            int n3 = int.Parse(Console.ReadLine());
            Console.WriteLine(PositiveNegativeOrZero(n1,n2,n3));
        }
        static string PositiveNegativeOrZero(int n1, int n2, int n3)
        {
            int negativeCount = 0;

            if (n1 == 0 || n2 == 0|| n3 == 0)
            {
                return "zero";
            }
            if (n1 < 0)
            {
                negativeCount++;
            }
            if (n2 < 0)
            {
                negativeCount++;
            }
            if (n3 < 0)
            {
                negativeCount++;
            }
            if (negativeCount % 2 == 0)
            {
                return "positive";
            }
            else
            {
                return "negative";
            }
        }
    }
}
