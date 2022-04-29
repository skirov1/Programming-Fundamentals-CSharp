using System;
using System.Collections.Generic;
using System.Linq;

namespace _06.CardsGame
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> deck1 = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> deck2 = Console.ReadLine().Split().Select(int.Parse).ToList();

            int length = deck1.Count;
            int deck1Wins = 0;
            int deck2Wins = 0;

            while (deck1.Count > 0 & deck2.Count > 0)
            {
                if (deck1[0] > deck2[0])
                {
                    deck1.Add(deck1[0]);
                    deck1.Add(deck2[0]);
                    deck1.Remove(deck1[0]);
                    deck2.Remove(deck2[0]);
                    deck1Wins++;
                }
                else if (deck2[0] > deck1[0])
                {
                    deck2.Add(deck2[0]);
                    deck2.Add(deck1[0]);
                    deck2.Remove(deck2[0]);
                    deck1.Remove(deck1[0]);
                    deck2Wins++;
                }
                else if (deck1[0] == deck2[0])
                {
                    deck1.Remove(deck1[0]);
                    deck2.Remove(deck2[0]);
                }
            }
            int sum = 0;
            if (deck1Wins > deck2Wins)
            {
                foreach (var item in deck1)
                {
                    sum += item;
                }
                Console.WriteLine($"First player wins! Sum: {sum}");
            }
            else if (deck2Wins > deck1Wins)
            {
                foreach (var item in deck2)
                {
                    sum += item;
                }
                Console.WriteLine($"Second player wins! Sum: {sum}");
            }
            

        }
    }
}
