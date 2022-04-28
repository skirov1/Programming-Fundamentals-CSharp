using System;

namespace _06.MiddleCharacters
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            PrintMiddleCharacter(text);
        }
        static void PrintMiddleCharacter(string text)
        {
            if (text.Length % 2 != 0)
            {
                for (int i = text.Length / 2; i <= text.Length / 2; i++)
                {
                    Console.WriteLine(text[i]);
                }
            }
            else
            {
                for (int i = text.Length / 2 - 1; i <= text.Length / 2; i++)
                {
                    Console.Write(text[i]);
                }
            }
        }
    }
}
