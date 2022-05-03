using System;

namespace _04.CaesarCipher
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();

            for (int i = 0; i < text.Length; i++)
            {
                int currentChar = (int)text[i] + 3;
                Console.Write((char)currentChar);
            }
        }
    }
}
