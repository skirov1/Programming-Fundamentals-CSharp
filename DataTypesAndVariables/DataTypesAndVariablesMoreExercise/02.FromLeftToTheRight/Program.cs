using System;
using System.Numerics;

namespace _02.FromLeftToTheRight
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();
                string[] numbers = input.Split(" ");
                long leftNumber = long.Parse(numbers[0]);
                long rightNumber = long.Parse(numbers[1]);
                

                if (leftNumber > rightNumber)
                {
                    long sum = 0;
                    leftNumber = Math.Abs(leftNumber);
                    rightNumber = Math.Abs(rightNumber);
                    while (leftNumber > 0)
                    {
                        sum += leftNumber % 10;
                        leftNumber /= 10;
                    }
                    Console.WriteLine(sum);
                }
                else
                {
                    long sum = 0;
                    leftNumber = Math.Abs(leftNumber);
                    rightNumber = Math.Abs(rightNumber);
                    while (rightNumber > 0)
                    {
                        sum += rightNumber % 10;
                        rightNumber /= 10;
                    }
                    Console.WriteLine(sum);
                }
            }

        }
    }
}
