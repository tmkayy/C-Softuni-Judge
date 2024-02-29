using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WildFarm.Models.Foods;

namespace WildFarm.Models.Animals.Birds
{
    public class Hen : Bird
    {
        public Hen(string name, double weight, double wingSize) : base(name, weight, wingSize)
        {
        }

        public override string Sound() => "Cluck";

        public override void Eat(Food f)
        {
            Weight += 0.35*f.Quantity;
            FoodEaten += f.Quantity;
        }
    }
}
