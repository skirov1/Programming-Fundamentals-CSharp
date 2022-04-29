using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.Messaging
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            string rawText = Console.ReadLine();
            List<char> text = new List<char>();
            text = rawText.ToList();
            string message = "";

            while (message.Length < numbers.Count)
            {
                for (int i = 0; i < numbers.Count; i++)
                {
                    int sum = 0;
                    while (numbers[i] > 0)
                    {
                        sum += numbers[i] % 10;
                        numbers[i] /= 10;
                    }
                    if (sum < text.Count)
                    {
                        message += text[sum];
                        text.RemoveAt(sum);
                    }
                    else
                    {
                        sum -= text.Count;
                        message += text[sum];
                        text.RemoveAt(sum);
                    }
                }

            }
            Console.WriteLine(message);
        }
    }
}
