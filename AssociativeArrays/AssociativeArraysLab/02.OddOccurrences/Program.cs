using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.OddOccurrences
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> elementsOccurences = new Dictionary<string, int>();

            string[] input = Console.ReadLine().Split();

            for (int i = 0; i < input.Length; i++)
            {
                string word = input[i].ToLower();
                if (!elementsOccurences.ContainsKey(word))
                {
                    elementsOccurences.Add(word, 0);
                }
                elementsOccurences[word]++;
            }

            elementsOccurences = elementsOccurences.Where(x => x.Value % 2 != 0).ToDictionary(x => x.Key,
            x => x.Value);

            foreach (var item in elementsOccurences)
            {
                Console.Write($"{item.Key} ");
            }
        }
    }
}
