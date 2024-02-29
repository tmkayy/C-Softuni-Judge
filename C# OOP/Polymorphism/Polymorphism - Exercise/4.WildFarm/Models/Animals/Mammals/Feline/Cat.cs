using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WildFarm.Models.Foods;

namespace WildFarm.Models.Animals.Mammals.Feline
{
    public class Cat : Feline
    {
        public Cat(string name, double weight, string livingRegion, string breed) : base(name, weight, livingRegion, breed)
        {
        }

        public override string Sound() => "Meow";

        public override void Eat(Food f)
        {
            if (f is Meat or Vegetable)
            {
                Weight += 0.3*f.Quantity;
                FoodEaten += f.Quantity;
            }
            else
            {
                Console.WriteLine($"{this.GetType().Name} does not eat {f.GetType().Name}!");
            }
        }
    }
}
