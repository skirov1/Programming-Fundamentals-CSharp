using System;
using System.Linq;

namespace _06.EqualSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();

            if (arr.Length == 1)
            {
                Console.WriteLine(0);
                return;
            }
            
            for (int i = 0; i < arr.Length; i++)
            {
                int leftSum = 0;
                int rightSum = 0;
                for (int j = 0; j < i; j++)
                {
                    leftSum += arr[j];
                }
                for (int j = i + 1; j < arr.Length; j++)
                {
                    rightSum += arr[j];
                }
                if (leftSum == rightSum)
                {
                    Console.WriteLine(i);
                    return;
                }               
            }
            Console.WriteLine("no");
            
        }
    }
}
