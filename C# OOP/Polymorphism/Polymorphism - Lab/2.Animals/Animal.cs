using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    public class Animal
    {
        string? name;
        string? favouriteFood;

        public Animal(string name, string favouriteFood)
        {
            Name = name;
            FavouriteFood = favouriteFood;
        }

        public string Name { get => name; set => name = value; }
        public string FavouriteFood { get => favouriteFood; set => favouriteFood = value; }

        public virtual string ExplainSelf() => $"I am {Name} and my favourite food is {FavouriteFood}";
    }
}
