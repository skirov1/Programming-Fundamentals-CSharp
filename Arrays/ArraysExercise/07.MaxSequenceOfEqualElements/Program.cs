using System;
using System.Linq;

namespace _07.MaxSequenceOfEqualElements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int length = 1;
            int bestLength = length;
            int number = arr[0];

            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i - 1] == arr[i])
                {
                    length++;
                }
                else
                {
                    length = 1;
                    if (length > bestLength)
                    {
                        bestLength = length;
                        number = arr[i];
                    }
                    
                }
                if (length > bestLength)
                {
                    bestLength = length;
                    number = arr[i - 1];
                }
            }
            for (int i = 0; i < bestLength; i++)
            {
                Console.Write(number + " ");
            }
        }
    }
}
