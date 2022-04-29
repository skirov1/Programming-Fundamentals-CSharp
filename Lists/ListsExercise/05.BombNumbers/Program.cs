using System;
using System.Collections.Generic;
using System.Linq;

namespace _05.BombNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            int[] bombs = Console.ReadLine().Split().Select(int.Parse).ToArray();

            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] == bombs[0])
                {
                    int count = 0;
                    for (int j = i + 1; j < i + bombs[1]; j++)
                    {
                        if (j < numbers.Count)
                        {
                            numbers.RemoveAt(j);
                            count++;
                            if (count == bombs[1])
                            {
                                continue;
                            }
                            j--;
                        }
                    }
                    for (int k = i - 1; k >= i - bombs[1]; k--)
                    {
                        if (k >= 0)
                        {
                            numbers.RemoveAt(k);
                        }
                    }
                }
            }
            numbers.RemoveAll(item => item == bombs[0]);
            int sum = 0;
            foreach (var item in numbers)
            {
                sum += item;
            }
            Console.WriteLine(sum);
        }
    }
}
