using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace _01.MatchFullName
{
    class Program
    {
        static void Main(string[] args)
        {
            Regex regex = new Regex(@"\b[A-Z][a-z]+ [A-Z][a-z]+\b");

            string names = Console.ReadLine();

            MatchCollection matchedNames = regex.Matches(names);

            foreach (Match match in matchedNames)
            {
                Console.Write(match.Value + " ");
            }
        }
    }
}
