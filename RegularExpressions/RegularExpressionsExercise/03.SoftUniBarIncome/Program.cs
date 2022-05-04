using System;
using System.Text.RegularExpressions;

namespace _03.SoftUniBarIncome
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                string data = Console.ReadLine();
                if (data == "end of shift")
                {
                    break;
                }

                Match match = Regex.Match(data, @"%(?<name>[A-Z][a-z]+)%.?\<(?<product>[A-Z][a-z]+)\>.?\|(?<count>\d+)\|(?<price>\d+\.?\d+\$)");
                Console.WriteLine(match.Groups["name"].Value);
            }
        }
    }
}
