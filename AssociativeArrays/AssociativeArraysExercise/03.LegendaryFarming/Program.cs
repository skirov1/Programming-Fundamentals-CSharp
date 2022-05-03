using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.LegendaryFarming
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> items = new Dictionary<string, int>()
            {
                {"shards", 0 },
                {"motes", 0 },
                {"fragments", 0}
            };

            while (true)
            {

                string[] data = Console.ReadLine().Split();
                bool isDone = false;

                for (int i = 0; i < data.Length; i++)
                {
                    if (i % 2 != 0)
                    {
                        string item = data[i].ToLower();
                        int quantity = int.Parse(data[i - 1]);
                        if (!items.ContainsKey(item))
                        {
                            items.Add(item, quantity);
                            if (items["motes"] >= 250 || items["fragments"] >= 250 || items["shards"] >= 250)
                            {
                                if (items["motes"] >= 250)
                                {
                                    items["motes"] -= 250;
                                    Console.WriteLine("Dragonwrath obtained!");
                                }
                                else if (items["fragments"] >= 250)
                                {
                                    items["fragments"] -= 250;
                                    Console.WriteLine("Valanyr obtained!");
                                }
                                else if (items["shards"] >= 250)
                                {
                                    items["shards"] -= 250;
                                    Console.WriteLine("Shadowmourne obtained!");
                                }
                                isDone = true;
                                break;
                            }
                        }
                        else
                        {
                            items[item] += quantity;
                            if (items["motes"] >= 250 || items["fragments"] >= 250 || items["shards"] >= 250)
                            {
                                if (items["motes"] >= 250)
                                {
                                    items["motes"] -= 250;
                                    Console.WriteLine("Dragonwrath obtained!");
                                }
                                else if (items["fragments"] >= 250)
                                {
                                    items["fragments"] -= 250;
                                    Console.WriteLine("Valanyr obtained!");
                                }
                                else if (items["shards"] >= 250)
                                {
                                    items["shards"] -= 250;
                                    Console.WriteLine("Shadowmourne obtained!");
                                }
                                isDone = true;
                                break;
                            }
                        }
                    }
                }
                if (isDone)
                {
                    break;
                }
            }
            foreach (var item in items)
            {
                Console.WriteLine($"{item.Key}: {item.Value}");
            }
        }
    }
}
