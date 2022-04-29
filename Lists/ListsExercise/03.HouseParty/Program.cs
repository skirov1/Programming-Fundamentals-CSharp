using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.HouseParty
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> guests = new List<string>();
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split().ToArray();
                if (input.Length == 3)
                {
                    if (!guests.Contains(input[0]))
                    {
                        guests.Add(input[0]);
                    }
                    else
                    {
                        Console.WriteLine($"{input[0]} is already in the list!");
                    }
                }
                else if (input.Length == 4)
                {
                    if (guests.Contains(input[0]))
                    {
                        guests.Remove(input[0]);
                    }
                    else
                    {
                        Console.WriteLine($"{input[0]} is not in the list!");
                    }
                }
            }
            foreach (var item in guests)
            {
                Console.WriteLine(item);
            }
        }
    }
}
