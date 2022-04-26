using System;

namespace _09.SpiceMustFlow
{
    class Program
    {
        static void Main(string[] args)
        {
            int yield = int.Parse(Console.ReadLine());
            int daysOperated = 0;
            int totalAmount = 0;

            while (yield >= 100)
            {
                daysOperated++;
                totalAmount += yield - 26;
                yield -= 10;
            }

            Console.WriteLine(daysOperated);
            if (totalAmount >= 26)
            {
                totalAmount -= 26;
            }
            Console.WriteLine(totalAmount);
        }
    }
}
