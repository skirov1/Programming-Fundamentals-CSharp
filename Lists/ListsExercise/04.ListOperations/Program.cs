using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.ListOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            string command = Console.ReadLine();

            while (command != "End")
            {
                string[] input = command.Split().ToArray();
                switch (input[0])
                {
                    case "Add":
                        AddCommand(numbers, int.Parse(input[1]));
                        break;
                    case "Insert":
                        InsertCommand(numbers, int.Parse(input[1]), int.Parse(input[2]));
                        break;
                    case "Remove":
                        RemoveCommand(numbers, int.Parse(input[1]));
                        break;
                    case "Shift":
                        if (input[1] == "left")
                        {
                            ShiftLeftCommand(numbers, int.Parse(input[2]));
                        }
                        else if (input[1] == "right")
                        {
                            ShiftRightCommand(numbers, int.Parse(input[2]));
                        }
                        break;
                }
                command = Console.ReadLine();
            }
            Console.WriteLine(string.Join(" ", numbers));
        }
        static void AddCommand(List<int> list, int number)
        {
            list.Add(number);
        }
        static void InsertCommand(List<int> list, int number, int index)
        {
            if (index >= list.Count || index < 0)
            {
                Console.WriteLine("Invalid index");
            }
            else 
            {
                list.Insert(index, number);
            }
        }
        static void RemoveCommand(List<int> list, int index)
        {
            if (index >= list.Count || index < 0)
            {
                Console.WriteLine("Invalid index");
            }
            else 
            {
                list.RemoveAt(index);
            }

        }
        static void ShiftLeftCommand(List<int> list, int count)
        {
            int lastNumber = 0;
            for (int i = 0; i < count; i++)
            {
                for (int j = 1; j < list.Count; j++)
                {
                    if (j == 1)
                    {
                        lastNumber = list[0];
                    }
                    list[j - 1] = list[j];
                }
                list[list.Count - 1] = lastNumber;
            }
        }
        static void ShiftRightCommand(List<int> list, int count)
        {
            int firstNumber = 0;
            for (int i = 0; i < count; i++)
            {
                for (int j = 1; j < list.Count; j++)
                {
                    if (j == 1)
                    {
                        firstNumber = list[list.Count - 1];
                    }
                    list[list.Count - j] = list[list.Count - j - 1];
                }
                list[0] = firstNumber;
            }
        }
    }
}
