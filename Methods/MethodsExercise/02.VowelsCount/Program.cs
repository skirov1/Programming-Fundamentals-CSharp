using System;

namespace _02.VowelsCount
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine().ToLower();
            Console.WriteLine(FindVowelsCount(text));
        }       
        static int FindVowelsCount(string text)
        {
            int vowelsCount = 0;
            for (int i = 0; i < text.Length; i++)
            {
                switch (text[i])
                {
                    case 'a':
                        vowelsCount++;
                        break;
                    case 'e':
                        vowelsCount++;
                        break;
                    case 'o':
                        vowelsCount++;
                        break;
                    case 'u':
                        vowelsCount++;
                        break;
                    case 'i':
                        vowelsCount++;
                        break;
                }
            }
            return vowelsCount;
        }
    }
}
