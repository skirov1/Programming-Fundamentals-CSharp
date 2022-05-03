using System;

namespace _02.AsciiSumator
{
    class Program
    {
        static void Main(string[] args)
        {
            char firstChar = char.Parse(Console.ReadLine());
            char secondChar = char.Parse(Console.ReadLine());
            string randomString = Console.ReadLine();
            int sum = 0;

            for (int i = (int)firstChar + 1; i < (int)secondChar - 1; i++)
            {
                for (int j = 0; j < randomString.Length; j++)
                {
                    if (randomString[j] == (char)i)
                    {
                        sum += i;
                    }
                }
            }

            Console.WriteLine(sum);

        }
    }
}
