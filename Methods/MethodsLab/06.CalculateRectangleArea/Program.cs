using System;

namespace _06.CalculateRectangleArea
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(CalculateArea(double.Parse(Console.ReadLine()),
                double.Parse(Console.ReadLine()))); 
        }
        static double CalculateArea(double a, double b)
        {
            double area = a * b;
            return area;

        }
    }
}
