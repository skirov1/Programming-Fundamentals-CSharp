using System;
using System.Linq;

namespace _11.ArrayManipulator
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int index = int.Parse(Console.ReadLine());
            ExchangeArray(array, index);
        }
        static void ExchangeArray(int[] array, int index)
        {
            if (index >= array.Length)
            {
                Console.WriteLine("Invalid index!");
            }
            else
            {
                for (int i = 0; i <= index; i++)
                {
                    array[i] = array[array.Length - 1];
                }
            }
        }
    }
}
