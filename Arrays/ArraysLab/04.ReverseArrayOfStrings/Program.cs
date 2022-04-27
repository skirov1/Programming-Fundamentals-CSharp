using System;
using System.Linq;

namespace _04.ReverseArrayOfStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] text = Console.ReadLine().Split();

            for (int i = text.Length - 1; i >= 0; i--)
            {
                Console.Write(text[i] + " ");
            }
        }
    }
}
