using System;
using System.Collections.Generic;
using System.Linq;

namespace DefiningClasses
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var l = new List<Car>();
            for (int i = 0; i < n; i++)
            {
                string[] s = Console.ReadLine().Split(' ');
                Engine e = new Engine(double.Parse(s[1]), double.Parse(s[2]));
                Cargo c = new Cargo(s[4], double.Parse(s[3]));
                Tire[] tires = new Tire[4]; int pres = 5; int age = 6;
                for (int j = 0; j < 4; j++, age+=2, pres +=2)
                    tires[j] = new Tire(double.Parse(s[age]), double.Parse(s[pres]));
                Car car = new Car(s[0], e, c, tires);
                l.Add(car);
            }
            string st = Console.ReadLine();
            if (st=="fragile")
            {
                foreach (var item in l.Where(x=>x.Cargo.Type=="fragile"&&x.Tires.Any(x=>x.Pressure<1)))
                {
                    Console.WriteLine(item.Model);
                }
            }
            else
            {
                foreach (var item in l.Where(x => x.Cargo.Type == "flammable" && x.Engine.Power>250))
                {
                    Console.WriteLine(item.Model);
                }
            }
        }
    }
}
