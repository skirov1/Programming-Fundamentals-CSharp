using System;
using System.Linq;

namespace _09.PalindromeIntegers
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            IsPalindrome(input);
        }
        static string ReverseInput(string input)
        {
            char[] characters = input.ToCharArray();
            string reveresedInput = String.Empty;
            for (int i = characters.Length - 1; i >= 0; i--)
            {
                reveresedInput += characters[i];
            }
            return reveresedInput;
        }
        static void IsPalindrome(string input)
        {
            while (input != "END")
            {
                string reversedInput = ReverseInput(input);
                if (input == reversedInput)
                {
                    Console.WriteLine("true");
                }
                else
                {
                    Console.WriteLine("false");
                }
                input = Console.ReadLine();
            }
        }
    }
}
