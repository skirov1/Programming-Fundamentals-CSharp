using System;

namespace _03.Substring
{
    class Program
    {
        static void Main(string[] args)
        {
            string substring = Console.ReadLine();
            string text = Console.ReadLine();

            for (int i = 0; i < text.Length; i++)
            {
                int startIndex = text.IndexOf(substring);
                if (startIndex >= 0)
                {
                    text = text.Remove(startIndex, substring.Length);
                }
            }
            Console.WriteLine(text);
        }
    }
}
