using System;
using System.Linq;

namespace _07.EqualArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array1 = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] array2 = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int sum = 0;

            for (int i = 0; i < array1.Length; i++)
            {
                sum += array1[i];
                for (int j = i; j <= i; j++)
                {
                    if (array1[i] != array2[j])
                    {
                        Console.WriteLine($"Arrays are not identical. Found difference at {i} index");
                        return;
                    }
                }
            }
            Console.WriteLine($"Arrays are identical. Sum: {sum}");
        }
    }
}
