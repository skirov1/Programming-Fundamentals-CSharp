using System;

namespace _07.WaterOverflow
{
    class Program
    {
        static void Main(string[] args)
        {
            int capacity = 255;

            int n = int.Parse(Console.ReadLine());
            int liters = 0;
            int totalLiters = 0;

            for (int i = 0; i < n; i++)
            {
                int waterPoured = int.Parse(Console.ReadLine());
                liters += waterPoured;
                if (liters > capacity)
                {
                    Console.WriteLine("Insufficient capacity!");
                    liters -= waterPoured;
                }
                else
                {
                    totalLiters = liters;
                }
            }
            Console.WriteLine(totalLiters);
        }
    }
}
