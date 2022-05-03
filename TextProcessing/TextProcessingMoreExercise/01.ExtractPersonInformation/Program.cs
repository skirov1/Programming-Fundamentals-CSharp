using System;

namespace _01.ExtractPersonInformation
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string data = Console.ReadLine();
                string name = string.Empty;
                string age = string.Empty;

                int nameIndex1 = data.IndexOf('@');
                int nameIndex2 = data.IndexOf('|');
                int ageIndex1 = data.IndexOf('#');
                int ageIndex2 = data.IndexOf('*');
                for (int j = nameIndex1 + 1; j < nameIndex2; j++)
                {
                    name += data[j];
                }
                for (int j = ageIndex1 + 1; j < ageIndex2; j++)
                {
                    age += data[j];
                }
                Console.WriteLine($"{name} is { age } years old.");
            }
        }
    }
}
