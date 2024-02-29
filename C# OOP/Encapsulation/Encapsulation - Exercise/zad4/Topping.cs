using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace zad4
{
    public class Topping
    {
        string name;
        double grams;

        public Topping(string name, double grams)
        {
            Name = name;
            Grams = grams;
        }

        string[] toppings = { "meat", "veggies", "cheese", "sauce" };

        public string Name
        {
            get => name; set
            {
                if (!toppings.Contains(value.ToLower()))
                {
                    throw new ArgumentException($"Cannot place {value} on top of your pizza.");
                }
                name = value;
            }
        }
        public double Grams
        {
            get => grams; set
            {
                if (value > 50 || value < 1)
                {
                    throw new ArgumentException($"{Name} weight should be in the range [1..50].");
                }
                grams = value;
            }
        }

        public double GetCal()
        {
            switch (Name.ToLower())
            {
                case "meat":
                    return 2 * 1.2 * Grams;
                case "veggies":
                    return 2 * 0.8 * Grams;
                case "cheese":
                    return 2 * 1.1 * Grams;
                case "sauce":
                    return 2 * 0.9 * Grams;
                default:
                    return 0;
            }
        }
    }
}
