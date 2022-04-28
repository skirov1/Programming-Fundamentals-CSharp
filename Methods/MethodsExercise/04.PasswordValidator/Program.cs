using System;

namespace _04.PasswordValidator
{
    class Program
    {
        static void Main(string[] args)
        {
            string password = Console.ReadLine();
            if (Has6To10Characters(password) && ContainsOnlyLettersAndDigits(password) 
                && Has2Digits(password))
            {
                Console.WriteLine("Password is valid");
            }
            if (!Has6To10Characters(password))
            {
                Console.WriteLine("Password must be between 6 and 10 characters");
            }
            if (!ContainsOnlyLettersAndDigits(password))
            {
                Console.WriteLine("Password must consist only of letters and digits");
            }
            if (!Has2Digits(password))
            {
                Console.WriteLine("Password must have at least 2 digits");
            }
                   
        }      
        static bool Has6To10Characters(string text)
        {
            if (text.Length < 6 || text.Length > 10)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        static bool ContainsOnlyLettersAndDigits(string text)
        {
            for (int i = 0; i < text.Length; i++)
            {
                if (!Char.IsDigit(text[i]) && !Char.IsLetter(text[i]))
                {
                    return false;
                }               
            }
            return true;
        }
        static bool Has2Digits(string text)
        {
            int digitsCount = 0;
            for (int i = 0; i < text.Length; i++)
            {
                if (Char.IsDigit(text[i]))
                {
                    digitsCount++;
                }
            }
            if (digitsCount < 2)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
