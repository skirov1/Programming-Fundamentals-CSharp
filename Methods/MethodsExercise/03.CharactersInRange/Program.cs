using System;

namespace _03.CharactersInRange
{
    class Program
    {
        static void Main(string[] args)
        {
            char a = char.Parse(Console.ReadLine());
            char b = char.Parse(Console.ReadLine());
            PrintCharacters(a, b);
        }
        static void PrintCharacters(char a, char b)
        {
            if ((char)b > (char)a)
            {
                for (int i = (char)a + 1; i < (char)b; i++)
                {
                    Console.Write((char)i + " ");
                }
            }
            else
            {
                for (int i = (char)b + 1; i < (char)a; i++)
                {
                    Console.Write((char)i + " ");
                }
            }

        }
    }
}
