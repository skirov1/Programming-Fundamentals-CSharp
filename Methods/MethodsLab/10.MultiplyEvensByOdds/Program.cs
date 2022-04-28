using System;

namespace _10.MultiplyEvensByOdds
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = Math.Abs(int.Parse(Console.ReadLine()));
            int evenSum = GetSumOfEvenDigits(number);
            int oddSum = GetSumOfOddDigits(number);
            Console.WriteLine(GetMultipleOfEvenAndOdds(evenSum, oddSum)); 
        }
        static int GetSumOfEvenDigits(int number)
        {
            int evenSum = 0;
            while (number > 0)
            {
                int digit = number % 10;
                if (digit % 2 == 0)
                {
                    evenSum += digit;
                }
                number /= 10;
            }
            return evenSum;
        }
        static int GetSumOfOddDigits(int number)
        {
            int oddSum = 0;
            while (number > 0)
            {
                int digit = number % 10;
                if (digit % 2 != 0)
                {
                    oddSum += digit;
                }
                number /= 10;
            }
            return oddSum;
        }
        static int GetMultipleOfEvenAndOdds(int evenSum, int oddSum)
        {            
            int multipleOfEvenAndOdds = evenSum * oddSum;
            return multipleOfEvenAndOdds;
        }
    }
}
