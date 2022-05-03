using System;

namespace _08.LettersChangeNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] data = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            double totalSum = 0;

            for (int i = 0; i < data.Length; i++)
            {
                string currentWord = data[i];
                string currentNumberString = string.Empty;
                for (int j = 1; j < currentWord.Length - 1; j++)
                {
                    if (char.IsDigit(currentWord[j]))
                    {
                        currentNumberString += currentWord[j];
                    }
                }
                double currentNumber = double.Parse(currentNumberString);
                for (int j = 0; j < currentWord.Length; j++)
                {
                    if (j == 0)
                    {
                        char currentChar = currentWord[j];
                        double currentCharValue = (int)currentChar % 32;
                        if (char.IsUpper(currentChar))
                        {
                            currentNumber /= currentCharValue;
                        }
                        else
                        {
                            currentNumber *= currentCharValue;
                        }
                    }
                    else if (j == currentWord.Length - 1)
                    {
                        char currentChar = currentWord[j];
                        double currentCharValue = (int)currentChar % 32;
                        if (char.IsUpper(currentChar))
                        {
                            currentNumber -= currentCharValue;
                        }
                        else
                        {
                            currentNumber += currentCharValue;
                        }
                    }
                }
                totalSum += currentNumber;
            }
            Console.WriteLine($"{totalSum:f2}");
        }
    }
}
