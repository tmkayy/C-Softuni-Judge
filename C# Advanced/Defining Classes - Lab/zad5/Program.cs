using System;
using System.Collections.Generic;
using System.Linq;

namespace CarManufacturer
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            var tlist = new List<Tire[]>();
            var elist = new List<Engine>();
            while (true)
            {
                string[] s = Console.ReadLine().Split(' ');
                if (s[0] == "No")
                    break;
                var tires = new Tire[4] { new Tire(int.Parse(s[0]), double.Parse(s[1])), new Tire(int.Parse(s[2]), double.Parse(s[3])), new Tire(int.Parse(s[4]), double.Parse(s[5])), new Tire(int.Parse(s[6]), double.Parse(s[7])) };
                tlist.Add(tires);
            }
            while (true)
            {
                string[] s = Console.ReadLine().Split(' ');
                if (s[0] == "Engines")
                    break;
                var e  = new Engine(int.Parse(s[0]), double.Parse(s[1]));
                elist.Add(e);
            }
            var cars = new List<Car>();
            while (true)
            {
                string[] s = Console.ReadLine().Split(' ');
                if (s[0] == "Show")
                    break;
                var c = new Car(s[0], s[1], int.Parse(s[2]), double.Parse(s[3]), double.Parse(s[4]), elist[int.Parse(s[5])], tlist[int.Parse(s[6])]);
                cars.Add(c);
            }
            foreach (var item in cars.Where(x=>x.Year>=2017&&x.Engine.HorsePower>330&&x.Tires.Sum(x=>x.Pressure)>=9&& x.Tires.Sum(x => x.Pressure) <= 10))
            {
                item.Spec();
            }
        }
    }
}
