using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text.RegularExpressions;

namespace _02.Race
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> stats = new Dictionary<string, int>();
            string[] names = Console.ReadLine().Split(", ");

            foreach (var name in names)
            {
                stats.Add(name, 0);
            }
            Regex regexNames = new Regex(@"[A-Za-z]");
            Regex regexNums = new Regex(@"\d");
            while (true)
            {
                string data = Console.ReadLine();
                if (data == "end of race")
                {
                    break;
                }
                int currentSum = 0;
                string currentName = string.Empty;
                MatchCollection nameMatch = regexNames.Matches(data);
                MatchCollection numMatch = regexNums.Matches(data);

                foreach (Match item in nameMatch)
                {
                    currentName += item.Value;
                }
                foreach (Match item in numMatch)
                {
                    currentSum += int.Parse(item.Value);
                }
                if (stats.ContainsKey(currentName))
                {
                    stats[currentName] += currentSum;
                }
            }
            var sortedStats = stats.OrderByDescending(x => x.Value).ToDictionary(x => x.Key, x => x.Value).Take(3);
            int count = 1;
            foreach (var item in sortedStats)
            {
                if (count == 1)
                {
                    Console.WriteLine($"1st place: {item.Key}");
                    count++;
                }
                else if (count == 2)
                {
                    Console.WriteLine($"2nd place: {item.Key}");
                    count++;
                }
                else if (count == 3)
                {
                    Console.WriteLine($"3rd place: {item.Key}");
                    count++;
                }
            }
        }
    }
}
