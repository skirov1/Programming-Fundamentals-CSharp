using System;
using System.Collections.Generic;
using System.Linq;

namespace _06.StoreBoxes
{
    class Item
    {
        public string ItemName { get; set; }
        public double ItemPrice { get; set; }
    }
    class Box
    {
        public Box()
        {
            Item = new Item();
        }
        public string SerialNumber { get; set; }
        public Item Item { get; set; }
        public int ItemQuantity { get; set; }
        public double PriceForBox { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            List<Box> boxes = new List<Box>();

            while (true)
            {
                string[] data = Console.ReadLine().Split();
                if (data[0] == "end")
                {
                    break;
                }

                string serialNumber = data[0];
                string itemName = data[1];
                int itemQuantity = int.Parse(data[2]);
                double itemPrice = double.Parse(data[3]);

                Box box = new Box();
                box.SerialNumber = serialNumber;
                box.Item.ItemName = itemName;
                box.ItemQuantity = itemQuantity;
                box.Item.ItemPrice = itemPrice;
                box.PriceForBox = box.ItemQuantity * box.Item.ItemPrice;
                boxes.Add(box);
            }
            List<Box> sortedBox = boxes.OrderByDescending(boxes => boxes.PriceForBox).ToList();
            foreach (var item in sortedBox)
            {
                Console.WriteLine(item.SerialNumber);
                Console.WriteLine($"-- {item.Item.ItemName} - ${item.Item.ItemPrice:f2}: {item.ItemQuantity}");
                Console.WriteLine($"-- ${item.PriceForBox:f2}");
            }
        }
    }
}
