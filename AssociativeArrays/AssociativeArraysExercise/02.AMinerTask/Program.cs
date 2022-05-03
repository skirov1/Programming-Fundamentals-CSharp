using System;
using System.Collections.Generic;

namespace _02.AMinerTask
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> resoruces = new Dictionary<string, int>();

            while (true)
            {
                string resource = Console.ReadLine();
                if (resource == "stop")
                {
                    break;
                }
                int quantity = int.Parse(Console.ReadLine());

                if (!resoruces.ContainsKey(resource))
                {
                    resoruces.Add(resource, 0);
                }
                resoruces[resource] += quantity;
            }

            foreach (var item in resoruces)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}
