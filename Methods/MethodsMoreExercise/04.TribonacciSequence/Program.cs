using System;

namespace _04.TribonacciSequence
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            PrintSequence(num);
        }
        static void PrintSequence(int num)
        {
            int[] numbers = new int[num];
            numbers[0] = 1;
            numbers[1] = 1;
            numbers[2] = 2;
            for (int i = 3; i < numbers.Length; i++)
            {
                numbers[i] = numbers[i - 1] + numbers[i - 2] + numbers[i - 3];
            }
            foreach (var item in numbers)
            {
                Console.Write(item + " ");
            }
        }
    }
}
