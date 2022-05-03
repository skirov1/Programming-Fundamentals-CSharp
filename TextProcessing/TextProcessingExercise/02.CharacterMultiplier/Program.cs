using System;

namespace _02.CharacterMultiplier
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] texts = Console.ReadLine().Split();
            MultiplyChars(texts[0], texts[1]);
        }
        static void MultiplyChars(string text1, string text2)
        {
            int shorterText = text1.Length;
            int longerText = text2.Length;
            int sum = 0;
            if (text2.Length < shorterText)
            {
                shorterText = text2.Length;
                longerText = text1.Length;
            }
            
            for (int i = 0; i < shorterText; i++)
            {
                sum += (char)text1[i] * (char)text2[i];
            }
            if (longerText == text1.Length)
            {
                for (int i = shorterText; i < text1.Length; i++)
                {
                    sum += (char)text1[i];
                }
            }
            else
            {
                for (int i = shorterText; i < text2.Length; i++)
                {
                    sum += (char)text2[i];
                }
            }
            Console.WriteLine(sum);
        }
    }
}
