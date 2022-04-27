using System;
using System.Linq;

namespace _01._EncryptSortAndPrintArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
           
            int[] codes = new int[n];

            for (int i = 0; i < n; i++)
            {
                string command = Console.ReadLine();
                int currentCode = 0;
                for (int j = 0; j < command.Length; j++)
                {
                    switch (command[j])
                    {
                        case 'a':
                        case 'e':
                        case 'i':
                        case 'o':
                        case 'u':
                        case 'A':
                        case 'E':
                        case 'I':
                        case 'O':
                        case 'U':
                            currentCode += (char)command[j] * command.Length;
                            break;
                        default:
                            currentCode += (char)command[j] / command.Length;
                            break;
                    }
                }
                codes[i] = currentCode;
            }
            Array.Sort(codes);
            foreach (var item in codes)
            {
                Console.WriteLine(item);
            }
        }
    }
}
