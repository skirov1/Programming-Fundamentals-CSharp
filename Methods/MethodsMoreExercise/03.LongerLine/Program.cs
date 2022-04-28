using System;

namespace _03.LongerLine
{
    class Program
    {
        static void Main(string[] args)
        {
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());
            double x3 = double.Parse(Console.ReadLine());
            double y3 = double.Parse(Console.ReadLine());
            double x4 = double.Parse(Console.ReadLine());
            double y4 = double.Parse(Console.ReadLine());
            FindLongestLine(x1, y1, x2, y2, x3, y3, x4, y4);
        }
        static void FindLongestLine(double x1, double y1, double x2, double y2
            , double x3, double y3, double x4, double y4)
        {
            double line1 = Math.Abs(x1) + Math.Abs(y1) + Math.Abs(x2) + Math.Abs(y2);
            double line2 = Math.Abs(x3) + Math.Abs(y3) + Math.Abs(x4) + Math.Abs(y4);
            double[] lineArray = new double[4];
            if (line1 > line2)
            {
                lineArray[0] = x1;
                lineArray[1] = y1;
                lineArray[2] = x2;
                lineArray[3] = y2;
            }
            else if (line2 > line1)
            {
                lineArray[0] = x3;
                lineArray[1] = y3;
                lineArray[2] = x4;
                lineArray[3] = y4;
            }
            else if (line1 == line2)
            {
                lineArray[0] = x1;
                lineArray[1] = y1;
                lineArray[2] = x2;
                lineArray[3] = y2;
            }
            ClosestToZero(lineArray);
        }
        static void ClosestToZero(double[] array)
        {
            double sum1 = Math.Abs(array[0]) + Math.Abs(array[1]);
            double sum2 = Math.Abs(array[2]) + Math.Abs(array[3]);

            if (sum1 <= sum2)
            {
                Console.Write($"({array[0]}, {array[1]})({array[2]}, {array[3]})");
            }
            else
            {
                Console.Write($"({array[2]}, {array[3]})({array[0]}, {array[1]})");
            }
        }
    }
}
