using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.ChangeList
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            string command = Console.ReadLine();

            while (command != "end")
            {
                string[] input = command.Split().ToArray();
                switch (input[0])
                {
                    case "Delete":
                        numbers.RemoveAll(item => item == int.Parse(input[1]));
                        break;
                    case "Insert":
                        numbers.Insert(int.Parse(input[2]), int.Parse(input[1]));
                        break;
                }
                command = Console.ReadLine();
            }
            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
