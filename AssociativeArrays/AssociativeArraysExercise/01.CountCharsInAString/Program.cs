using System;
using System.Collections.Generic;

namespace _01.CountCharsInAString
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<char, int> charOccurrences = new Dictionary<char, int>();
            string input = Console.ReadLine();

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] != ' ')
                {
                    char currentChar = input[i];
                    if (!charOccurrences.ContainsKey(currentChar))
                    {
                        charOccurrences.Add(currentChar, 0);
                    }
                    charOccurrences[currentChar]++;
                }
            }

            foreach (var item in charOccurrences)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}
