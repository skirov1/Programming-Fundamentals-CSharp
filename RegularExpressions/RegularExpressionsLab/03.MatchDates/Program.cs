using System;
using System.Text.RegularExpressions;

namespace _03.MatchDates
{
    class Program
    {
        static void Main(string[] args)
        {
            Regex regex = new Regex(@"\b\s?(?<day>\d{2})(?<separator>[.\-\/])(?<month>[A-Z][a-z]{2})(\k<separator>)(?<year>\d{4})\b");
            string dates = Console.ReadLine();
            MatchCollection matchedDates = regex.Matches(dates);

            foreach (Match date in matchedDates)
            {
                Console.WriteLine($"Day: {date.Groups["day"].Value}, Month: {date.Groups["month"].Value}, Year: {date.Groups["year"].Value}");
            }
        }
    }
}
