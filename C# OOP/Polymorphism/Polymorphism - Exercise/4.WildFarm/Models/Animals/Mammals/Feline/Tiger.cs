using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WildFarm.Models.Foods;

namespace WildFarm.Models.Animals.Mammals.Feline
{
    public class Tiger : Feline
    {
        public Tiger(string name, double weight, string livingRegion, string breed) : base(name, weight, livingRegion, breed)
        {
        }

        public override string Sound() => "ROAR!!!";

        public override void Eat(Food f)
        {
            if (f is Meat)
            {
                Weight += 1*f.Quantity;
                FoodEaten += f.Quantity;
            }
            else
            {
                Console.WriteLine($"{this.GetType().Name} does not eat {f.GetType().Name}!");
            }
        }
    }
}
