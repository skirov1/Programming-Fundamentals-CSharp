using System;

namespace _10.TopNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            IsTop(n);
        }
        static void IsTop(int n)
        {     
            for (int i = 1; i <= n; i++)
            {
                bool isDivisibleBy8 = false;
                int oddDigitCount = 0;
                int number = i;
                int sum = 0;
                while (number > 0)
                {
                    sum += number % 10;
                    if ((number % 10) % 2 != 0)
                    {
                        oddDigitCount++;
                    }
                    number /= 10;
                }
                if (sum % 8 == 0)
                {
                    isDivisibleBy8 = true;
                }
                if (isDivisibleBy8 && oddDigitCount > 0)
                {
                    Console.WriteLine(i);
                }             
            }
        }
    }
}
