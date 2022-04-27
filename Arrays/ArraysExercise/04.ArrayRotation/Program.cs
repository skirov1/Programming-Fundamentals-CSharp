using System;
using System.Linq;

namespace _04.ArrayRotation
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int rotations = int.Parse(Console.ReadLine());
            int lastElement = 0;

            for (int i = 0; i < rotations; i++)
            {
                for (int j = 1; j < arr.Length; j++)
                {
                    if (j == 1)
                    {
                        lastElement = arr[0];
                    }
                    arr[j - 1] = arr[j];
                }
                    arr[arr.Length - 1] = lastElement;
            }
            foreach (var item in arr)
            {
                Console.Write(item + " ");
            }
        }
    }
}
