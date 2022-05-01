using System;
using System.Linq;

namespace _01.RandomizeWords
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            Random rnd = new Random();

            for (int i = 0; i < input.Length; i++)
            {
                int index = rnd.Next(input.Length);
                string temp = input[i];
                input[i] = input[index];
                input[index] = temp;
            }
            foreach (var item in input)
            {
                Console.WriteLine(item);
            }
        }
    }
}
