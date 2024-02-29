using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WildFarm.Models.Foods;

namespace WildFarm.Models.Animals.Mammals
{
    public class Mouse : Mammal
    {
        public Mouse(string name, double weight, string livingRegion) : base(name, weight, livingRegion)
        {
        }

        public override string Sound() => "Squeak";

        public override void Eat(Food f)
        {
            if (f is Vegetable or Fruit)
            {
                Weight += 0.1 * f.Quantity;
                FoodEaten += f.Quantity;
            }
            else
            {
                Console.WriteLine($"{this.GetType().Name} does not eat {f.GetType().Name}!");
            }
        }
    }
}
