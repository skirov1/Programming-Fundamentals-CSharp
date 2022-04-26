using System;

namespace _12.RefactorSpecialNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int countOfNumbers = int.Parse(Console.ReadLine());
            bool isSpecial = false;
            for (int currentNumber = 1; currentNumber <= countOfNumbers; currentNumber++)
            {
                int sum = 0;
                int number = currentNumber;
                while (number > 0)
                {
                    sum += number % 10;
                    number /= 10;
                }
                if (sum == 5 || sum == 7 || sum == 11)
                {
                    isSpecial = true;
                }                
                Console.WriteLine("{0} -> {1}", currentNumber, isSpecial);
                isSpecial = false;
            }

        }
    }
}
