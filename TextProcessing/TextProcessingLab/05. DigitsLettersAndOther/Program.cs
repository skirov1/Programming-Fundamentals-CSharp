using System;

namespace _05._DigitsLettersAndOther
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();

            for (int i = 0; i < text.Length; i++)
            {
                if (char.IsDigit(text[i]))
                {
                    Console.Write(text[i]);
                }
            }
            Console.WriteLine();
            for (int i = 0; i < text.Length; i++)
            {
                if (char.IsLetter(text[i]))
                {
                    Console.Write(text[i]);
                }
            }
            Console.WriteLine();
            for (int i = 0; i < text.Length; i++)
            {
                if (!char.IsDigit(text[i]) && !char.IsLetter(text[i]))
                {
                    Console.Write(text[i]);
                }
            }
        }
    }
}
