using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace zad4
{
    public class Pizza
    {
        string name;
        Dough dough;
        List<Topping> toppings;

        public Pizza(string name, Dough dough)
        {
            Name = name;
            Dough = dough;
            Toppings = new List<Topping>();
        }
        public string Name
        {
            get => name;
            private set
            {
                if (value.Length < 1 || value.Length > 15)
                {
                    throw new ArgumentException($"Pizza name should be between {1} and {15} symbols.");

                }
                name = value;
            }
        }
        public Dough Dough { get => dough; set => dough = value; }
        public List<Topping> Toppings { get => toppings; set => toppings = value; }

        public void AddTopping(Topping topping)
        {
            if (toppings.Count > 10)
            {
                throw new ArgumentException("Number of toppings should be in range [0..10].");
            }
            toppings.Add(topping);
        }

        public override string ToString()
        {
            return $"{Name} - {Dough.GetCal() + toppings.Sum(x => x.GetCal()):f2} Calories.";
        }
    }
}
