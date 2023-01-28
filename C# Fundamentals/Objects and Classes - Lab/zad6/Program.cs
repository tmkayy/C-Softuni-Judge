using System;
using System.Collections.Generic;
using System.Linq;

namespace zad6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Box> Boxes = new List<Box>();
            while (true)
            {
                string[] input = Console.ReadLine().Split(' ').ToArray();
                if (input[0]=="end")
                {
                    break;
                }
                Box box = new Box();
                box.SerialNumber = input[0];
                box.Item = new Item();
                box.Item.Name = input[1];
                box.Quantity = int.Parse(input[2]);
                box.Item.Price =double.Parse(input[3]);
                box.PriceBox = box.Item.Price * box.Quantity;
                Boxes.Add(box);
            }
            foreach (Box box in Boxes.OrderByDescending(b => b.PriceBox))
            {
                Console.WriteLine(box);
            }
        }
        class Item
        {
            public string Name { get; set; }
            public double Price { get; set; }
        }
        class Box
        {
            public Box()
            {
                Item = new Item();
            }
            public string SerialNumber { get; set; }
            public Item Item { get; set; }
            public int Quantity { get; set; }
            public double PriceBox { get; set; }

            public override string ToString()
            {
                return $"{this.SerialNumber}\n-- {this.Item.Name} - ${this.Item.Price:f2}: {this.Quantity}\n-- ${this.PriceBox:f2}";
            }
        }
    }
}
