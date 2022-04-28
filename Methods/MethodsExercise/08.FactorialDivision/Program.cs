using System;

namespace _08.FactorialDivision
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            FactorialDivision(a, b);
        }
        static void FactorialDivision(double a, double b)
        {
            double firstFactorial = 1;
            double secondFactorial = 1;
            for (double i = a; i > 1; i--)
            {
                firstFactorial = i * firstFactorial;
            }
            for (double i = b; i > 1; i--)
            {
                secondFactorial = i * secondFactorial;
            }
            double division = 0;

            division = firstFactorial / secondFactorial;

            Console.WriteLine($"{division:f2}");
        }
    }
}
