
using System;
using System.Numerics;

namespace _11.Snowballs
{
    class Program
    {
        static void Main(string[] args)
        {
            int countOfSnowBalls = int.Parse(Console.ReadLine());
            string bestSnowball = String.Empty;
            BigInteger bestValue = 0;

            for (int i = 0; i < countOfSnowBalls; i++)
            {
                int snowballSnow = int.Parse(Console.ReadLine());
                int snowballTime = int.Parse(Console.ReadLine());
                int snowballQuality = int.Parse(Console.ReadLine());

                if (snowballTime > 0)
                {
                    BigInteger snowBallValue = BigInteger.Pow((snowballSnow / snowballTime), snowballQuality);

                    if (snowBallValue >= bestValue)
                    {
                        bestValue = snowBallValue;
                        bestSnowball = $"{snowballSnow} : {snowballTime} = {bestValue} ({snowballQuality})";
                    }
                }
            }
            Console.WriteLine(bestSnowball);

        }
    }
}
