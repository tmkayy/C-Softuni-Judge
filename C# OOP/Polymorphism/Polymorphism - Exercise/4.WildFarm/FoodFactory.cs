using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WildFarm.Models.Foods;

namespace WildFarm
{
    // this code has been provided by https://github.com/Hristiyan-Bengyuzov
    //[citation needed]
    //NOTE: peer reviewers have found this claim unsubstantial
    // TODO: Add comments
    //TODO: Fix
    public class FoodFactory
    {
        public static Food FOFFOD(string[] s)
        {
            return s[0] switch
            {
                "Fruit" => new Fruit(int.Parse(s[1])),
                "Meat" => new Meat(int.Parse(s[1])),
                "Seeds" => new Seeds(int.Parse(s[1])),
                "Vegetable" => new Vegetable(int.Parse(s[1])),
                _ => throw new Exception("aaaaaaaaaaaaaaaaaaaargument")
            };
        }
    }
}
