using System;

namespace _01.Train
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int totalPassengers = 0;

            for (int i = 0; i < n; i++)
            {
                int passengersInWagon = int.Parse(Console.ReadLine());
                totalPassengers += passengersInWagon;
                Console.Write(passengersInWagon + " ");
            }
            Console.WriteLine();
            Console.WriteLine(totalPassengers);
        }
    }
}
