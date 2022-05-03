using System;
using System.Linq;

namespace _03.TreasureFinder
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] keys = Console.ReadLine().Split().Select(int.Parse).ToArray();

            while (true)
            {
                string text = Console.ReadLine();
                string hiddenMessage = string.Empty;
                if (text == "find")
                {
                    break;
                }
                int keyIndex = 0;
                for (int i = 0; i < text.Length; i++)
                {
                    if (i != 0)
                    {
                        keyIndex++;
                    }
                    if (keyIndex == keys.Length)
                    {
                        keyIndex = 0;
                    }
                    int currentKey = keys[keyIndex];
                    char currentChar = text[i];
                    int currentCharValue = (int)currentChar;
                    currentCharValue -= currentKey;
                    currentChar = (char)currentCharValue;
                    hiddenMessage += currentChar;
                }
                string type = string.Empty;
                string coordinates = string.Empty;
                int typeIndex1 = hiddenMessage.IndexOf('&');
                int typeIndex2 = hiddenMessage.LastIndexOf('&');
                int coordinatesIndex1 = hiddenMessage.IndexOf('<');
                int coordinatesIndex2 = hiddenMessage.IndexOf('>');
                for (int i = typeIndex1 + 1; i < typeIndex2; i++)
                {
                    type += hiddenMessage[i];
                }
                for (int i = coordinatesIndex1 + 1; i < coordinatesIndex2; i++)
                {
                    coordinates += hiddenMessage[i];
                }
                Console.WriteLine($"Found {type} at {coordinates}");
            }
        }
    }
}
