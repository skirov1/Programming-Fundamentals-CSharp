using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.TakeSkipRope
{
    class Program
    {
        static void Main(string[] args)
        {
            string message = Console.ReadLine();
            List<int> numbersList = new List<int>();
            List<char> nonNumbersList = new List<char>();

            for (int i = 0; i < message.Length; i++)
            {
                if (Char.IsDigit(message[i]))
                {
                    string stringMessage = message[i].ToString();
                    numbersList.Add(int.Parse(stringMessage));
                }
                else
                {
                    nonNumbersList.Add(message[i]);
                }
            }

            List<int> skipList = new List<int>();
            List<int> takeList = new List<int>();

            for (int i = 0; i < numbersList.Count; i++)
            {
                if (i % 2 == 0)
                {
                    takeList.Add(numbersList[i]);
                }
                else
                {
                    skipList.Add(numbersList[i]);
                }
            }

            string result = "";
            int takeIndex = 0;

            for (int i = 0; i < takeList.Count; i++)
            {
                for (int j = 0; j < takeList[i]; j++)
                {
                    if (takeIndex < nonNumbersList.Count)
                    {
                        result += nonNumbersList[takeIndex];
                        takeIndex++;
                    }
                }
                for (int k = 0; k < skipList[i]; k++)
                {
                    if (skipList[i] != 0)
                    {
                        takeIndex++;
                    }
                }
            }
            Console.WriteLine(string.Join("", result));
        }
    }
}
