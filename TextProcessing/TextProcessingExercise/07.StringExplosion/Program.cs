using System;

namespace _07.StringExplosion
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            int strength = 0;

            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] != '>' && strength > 0)
                {
                    text = text.Remove(i, 1);
                    strength--;
                    i--;               
                }
                else if (text[i] == '>')
                {
                    strength += int.Parse(text[i + 1].ToString());
                }
            }
            Console.WriteLine(text);
        }
    }
}
