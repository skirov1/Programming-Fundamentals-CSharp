using System;

namespace _10.LowerOrUpper
{
    class Program
    {

        static void Main(string[] args)
        {
            char input = char.Parse(Console.ReadLine());
            bool result = false;

            result = Char.IsUpper(input);

            if (result)
            {
                Console.WriteLine("upper-case");
            }
            else
            {
                Console.WriteLine("lower-case");
            }
        }
    }
}
