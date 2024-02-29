using System;
using System.Collections.Generic;
using System.Text;

namespace Restaurant
{
    public class Cake : Dessert
    {
        double cakePrice;
        public Cake(string name) : base(name, 5m, 250, 1000)
        {
        }

        public double CakePrice { get => cakePrice; set => cakePrice = value; }
    }
}
