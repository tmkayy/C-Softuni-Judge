using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WildFarm.Models.Foods;

namespace WildFarm.Models.Animals.Birds
{
    public class Owl : Bird
    {
        public Owl(string name, double weight, double wingSize) : base(name, weight, wingSize)
        {
        }

        public override string Sound() => "Hoot Hoot";

        public override void Eat(Food f)
        {
            if (f is Meat)
            {
                Weight += 0.25*f.Quantity;
                FoodEaten += f.Quantity;
            }
            else
            {
                Console.WriteLine($"{this.GetType().Name} does not eat {f.GetType().Name}!");
            }
        }
    }
}
