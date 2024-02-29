using System;
using System.Collections.Generic;
using System.Text;

namespace Restaurant
{
    public class Product
    {
        string name;
        decimal price;

        public Product(string name, decimal price)
        {
            Name = name;
            Price = price;
        }

        public string Name { get => name; set => name = value; }
        public decimal Price { get => price; set => price = value; }
    }
}
