using System;
using System.Collections.Generic;
using System.Text;

namespace Restaurant
{
    public class Coffee:HotBeverage
    {
        const double coffeeMilliliters = 50;
        const decimal coffeePrice = 3.5m;
        double caffeine;

        public Coffee(string name, double caffeine) : base(name, coffeePrice, coffeeMilliliters)
        {
            Caffeine = caffeine;
        }

        public double Caffeine { get => caffeine; set => caffeine = value; }
    }
}
