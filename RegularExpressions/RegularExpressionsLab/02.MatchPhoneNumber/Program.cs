using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace _02.MatchPhoneNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Regex regex = new Regex(@"\s?(\+359)(?<separator>[\s-])([2]{1})(\k<separator>)([0-9]{3})(\k<separator>)([0-9]{4})\b");
            string phoneNumbers = Console.ReadLine();

            MatchCollection matchedPhones = regex.Matches(phoneNumbers);

            var phoneMatches = matchedPhones.Cast<Match>().Select(a => a.Value.Trim()).ToArray();

            Console.WriteLine(string.Join(", ", phoneMatches));
        }
    }
}
