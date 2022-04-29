using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.CarRace
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> times = Console.ReadLine().Split().Select(int.Parse).ToList();
            double leftCar = 0;
            double rightCar = 0;

            for (int i = 0; i < times.Count / 2; i++)
            {
                if (times[i] != 0)
                {
                    leftCar += times[i];
                }
                else
                {
                    leftCar *= 0.8;
                }
            }
            for (int i = times.Count - 1; i > times.Count / 2; i--)
            {
                if (times[i] != 0)
                {
                    rightCar += times[i];
                }
                else
                {
                    rightCar *= 0.8;
                }
            }
            if (leftCar < rightCar)
            {
                if (ConvertToInt(leftCar))
                {
                    Console.WriteLine($"The winner is left with total time: {leftCar}");
                }
                else
                {
                    Console.WriteLine($"The winner is left with total time: {leftCar:f1}");
                }
            }
            else if (rightCar < leftCar)
            {
                if (ConvertToInt(rightCar))
                {
                    Console.WriteLine($"The winner is right with total time: {rightCar}");
                }
                else
                {
                    Console.WriteLine($"The winner is right with total time: {rightCar:f1}");
                }                
            }
        }
        static bool ConvertToInt(double car)
        {
            string carText = car.ToString();
            int intCar = 0; 
            bool isInt = int.TryParse(carText, out intCar);
            return isInt;
        }
    }
}
