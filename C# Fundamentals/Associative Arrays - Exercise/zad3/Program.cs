using System;
using System.Collections.Generic;

namespace zad3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Product> products = new Dictionary<string, Product>();
            while (true)
            {
                string[] s = Console.ReadLine().Split(' ');
                if (s[0] == "buy")
                {
                    break;
                }
                if (products.ContainsKey(s[0]))
                {
                    if (products[s[0]].price == double.Parse(s[1]))
                    {
                        products[s[0]].quantity += int.Parse(s[2]);
                    }
                    else
                    {
                        products[s[0]].price = double.Parse(s[1]);
                        products[s[0]].quantity += int.Parse(s[2]);
                    }
                }
                else
                {
                    Product p = new Product();
                    p.price = double.Parse(s[1]);
                    p.quantity = int.Parse(s[2]);
                    products.Add(s[0], p);
                }
            }
            foreach (KeyValuePair<string, Product> resource in products)
            {
                Console.WriteLine($"{resource.Key} -> {resource.Value.price*resource.Value.quantity:f2}");
            }
        }
        class Product
        {
            public double price { get; set; }
            public int quantity { get; set; }
        }
    }
}
