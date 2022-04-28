using System;

namespace _07.RepeatString
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(RepeatString((Console.ReadLine()), int.Parse(Console.ReadLine())));
        }
        static string RepeatString(string text, int n)
        {
            string repeatedText = "";
            for (int i = 0; i < n; i++)
            {
                repeatedText += text;
            }
            return repeatedText;
        }
    }
}
