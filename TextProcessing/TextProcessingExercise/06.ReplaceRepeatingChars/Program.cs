using System;

namespace _06.ReplaceRepeatingChars
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();

            for (int i = 0; i < text.Length; i++)
            {
                char currentChar = text[i];
                int count = 0;
                int index = 0;
                for (int j = i; j < text.Length; j++)
                {
                    if (j == i)
                    {
                        index = j;
                    }
                    if (text[j] == currentChar)
                    {
                        count++;
                    }
                    else
                    {
                        break;
                    }
                }
                text.Insert(index, currentChar.ToString());
                if (index + 1 < text.Length)
                {
                    index += 1;
                }
                if (count > 1)
                {
                    count -= 1;
                    text = text.Remove(index, count);
                }
            }
            Console.WriteLine(text);
        }
    }
}
