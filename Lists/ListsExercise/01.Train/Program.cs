using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.Train
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> wagons = Console.ReadLine().Split().Select(int.Parse).ToList();
            int maxCapacity = int.Parse(Console.ReadLine());

            string command = Console.ReadLine();

            while (command != "end")
            {
                string[] input = command.Split().ToArray();
                if (input[0] == "Add")
                {
                    wagons.Add(int.Parse(input[1]));
                }
                else
                {
                    for (int i = 0; i < wagons.Count; i++)
                    {
                        if (wagons[i] + int.Parse(input[0]) <= maxCapacity)
                        {
                            wagons[i] += int.Parse(input[0]);
                            break;
                        }
                    }
                }
                command = Console.ReadLine();
            }
            foreach (var item in wagons)
            {
                Console.Write(item + " ");
            }
        }
    }
}
