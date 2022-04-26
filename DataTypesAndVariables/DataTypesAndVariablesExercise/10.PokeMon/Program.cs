using System;

namespace _10.PokeMon
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int M = int.Parse(Console.ReadLine());
            int Y = int.Parse(Console.ReadLine());
            int count = 0;
            double startingN = N * 0.50;

            while (N >= M)
            {
                if (N == startingN && Y > 0)
                {
                    N /= Y;
                    if (N < M)
                    {
                        break;
                    }
                }
                N -= M;
                count++;
            }
            Console.WriteLine(N);
            Console.WriteLine(count);
        }
    }
}
