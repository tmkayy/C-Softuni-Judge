using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WildFarm.Models.Foods;

namespace WildFarm.Models.Animals.Mammals
{
    public class Dog : Mammal
    {
        public Dog(string name, double weight, string livingRegion) : base(name, weight, livingRegion)
        {
        }

        public override void Eat(Food f)
        {
            if (f is Meat)
            {
                Weight += 0.4*f.Quantity;
                FoodEaten += 1*f.Quantity;
            }
            else
            {
                Console.WriteLine($"{this.GetType().Name} does not eat {f.GetType().Name}!");
            }
        }

        public override string Sound() => "Woof!";
    }
}
