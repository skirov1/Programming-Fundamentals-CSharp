using System;

namespace _01.ValidUsernames
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] usernames = Console.ReadLine().Split(", ");

            for (int i = 0; i < usernames.Length; i++)
            {
                if (IsValid(usernames[i]))
                {
                    Console.WriteLine(usernames[i]);
                }
            }
        }
        static bool IsBetween3And16(string username)
        {
            if (username.Length >= 3 && username.Length <= 16)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        static bool ContainsValidSymbols(string username)
        {
            bool isValid = true; 
            for (int i = 0; i < username.Length; i++)
            {
                if (!char.IsLetterOrDigit(username[i]) && username[i] != '_' && username[i] != '-')
                {
                    isValid = false;
                }
            }
            if (!isValid)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        static bool IsValid(string username)
        {
            if (IsBetween3And16(username) && ContainsValidSymbols(username))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}

    




