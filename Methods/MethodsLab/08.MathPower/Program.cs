using System;

namespace _08.MathPower
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(CalculatePower(double.Parse(Console.ReadLine()), 
                double.Parse(Console.ReadLine())));
        }
        static double CalculatePower(double number, double power)
        {
            double result = Math.Pow(number, power);
            return result;
        }
        
    }
}
