using System;

namespace _01.DataTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine();           
            switch (type)
            {
                case "int":
                    int integerNumber = int.Parse(Console.ReadLine());
                    Console.WriteLine(TypeInt(integerNumber));
                    break;
                case "real":
                    double realNumber = double.Parse(Console.ReadLine());
                    Console.WriteLine($"{TypeReal(realNumber):f2}");
                    break;
                case "string":
                    string text = Console.ReadLine();
                    Console.WriteLine(TypeString(text));
                    break;

            }
        }
        static int TypeInt(int n)
        {
            return n * 2;
        }
        static double TypeReal(double n)
        {
            return n * 1.5;
        }
        static string TypeString(string text)
        {
            return "$" + text + "$";
        }
    }
}
