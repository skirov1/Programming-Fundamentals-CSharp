using System;

namespace _09.GreaterOfTwoValues
{
    class Program
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine();
            string a = Console.ReadLine();
            string b = Console.ReadLine();

            switch (type)
            {
                case "string":
                    Console.WriteLine(GetMax(a,b)); 
                    break;
                case "char":
                    Console.WriteLine(GetMax(char.Parse(a), char.Parse(b)));
                    break;
                case "int":
                    Console.WriteLine(GetMax(int.Parse(a), int.Parse(b))); 
                    break;
            }
        }
        static string GetMax(string a, string b)
        {
            if (a.CompareTo(b) > 0)
            {
                return a;
            }
            else
            {
                return b;
            }
        }
        static char GetMax(char a, char b)
        {
            if (a > b)
            {
                return a;
            }
            else
            {
                return b;
            }
        }
        static int GetMax(int a, int b)
        {
            if (a > b)
            {
                return a;
            }
            else
            {
                return b;
            }
        }

    }
}
