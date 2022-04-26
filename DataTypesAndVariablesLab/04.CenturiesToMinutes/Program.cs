using System;

namespace _04.CenturiesToMinutes
{
    class Program
    {
        static void Main(string[] args)
        {
            byte century = byte.Parse(Console.ReadLine());
            short years = (short) (century * 100);
            int days = (int)(years * 365.2422);
            int hours = (int)(days * 24);
            long minutes = (long)(hours * 60);

            Console.WriteLine($"{century} centuries = {years} years = {days} days = " +
                $"{hours} hours = {minutes} minutes");
        }
    }
}
