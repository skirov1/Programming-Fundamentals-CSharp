using System;
using System.Collections.Generic;

namespace _04.MorseCodeTranslator
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, char> morseCode = new Dictionary<string, char>();
            morseCode.Add(".-", 'A');
            morseCode.Add("-...", 'B');
            morseCode.Add("-.-.", 'C');
            morseCode.Add("-..", 'D');
            morseCode.Add(".", 'E');
            morseCode.Add("..-.", 'F');
            morseCode.Add("--.", 'G');
            morseCode.Add("....", 'H');
            morseCode.Add("..", 'I');
            morseCode.Add(".---", 'J');
            morseCode.Add("-.-", 'K');
            morseCode.Add(".-..", 'L');
            morseCode.Add("--", 'M');
            morseCode.Add("-.", 'N');
            morseCode.Add("---", 'O');
            morseCode.Add(".--.", 'P');
            morseCode.Add("--.-", 'Q');
            morseCode.Add(".-.", 'R');
            morseCode.Add("...", 'S');
            morseCode.Add("-", 'T');
            morseCode.Add("..-", 'U');
            morseCode.Add("...-", 'V');
            morseCode.Add(".--", 'W');
            morseCode.Add("-..-", 'X');
            morseCode.Add("-.--", 'Y');
            morseCode.Add("--..", 'Z');

            string[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            string result = string.Empty;

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] != "|")
                {
                    result += morseCode[input[i]];
                }
                else
                {
                    result += " ";
                }
            }
            Console.WriteLine(result);
        }
    }
}
