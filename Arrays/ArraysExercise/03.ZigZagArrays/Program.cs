using System;
using System.Linq;

namespace _03.ZigZagArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string[] array1 = new string[n];
            string[] array2 = new string[n];

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split().ToArray();
                if (i % 2 == 0)
                {
                    array1[i] = input[0];
                    array2[i] = input[1];
                }
                else
                {
                    array1[i] = input[1];
                    array2[i] = input[0];
                }
            }
            foreach (var item in array1)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
            foreach (var item in array2)
            {
                Console.Write(item + " ");
            }
        }
    }
}
