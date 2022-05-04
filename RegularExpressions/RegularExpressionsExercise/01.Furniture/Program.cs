using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace _01.Furniture
{
    class Program
    {
        static void Main(string[] args)
        {
            double totalSum = 0;
            List<string> matches = new List<string>();
            while (true)
            {
                string data = Console.ReadLine();
                if (data == "Purchase")
                {
                    break;
                }
                Match match = Regex.Match(data, @">>(?<name>[A-Z][A-Z,a-z]+)<<(?<price>\d+\.?\d+)!(?<quantity>\d+)\b");
                if (match.Success)
                {
                    matches.Add(match.Groups["name"].Value);
                    totalSum += double.Parse(match.Groups["price"].Value) * double.Parse(match.Groups["quantity"].Value);
                }
            }
            Console.WriteLine("Bought furniture:");
            foreach (var item in matches)
            {
                Console.WriteLine($"{item}");
            }
            Console.WriteLine($"Total money spend: {totalSum:f2}");
        }
    }
}
