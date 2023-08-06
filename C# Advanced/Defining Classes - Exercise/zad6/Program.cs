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
            List<Car> list = new List<Car>();
            for (int i = 0; i < n; i++)
            {
                string[] s = Console.ReadLine().Split(' ');
                Car c = new Car(s[0], double.Parse(s[1]), double.Parse(s[2]), 0);
                list.Add(c);
            }
            while (true)
            {
                string[] s = Console.ReadLine().Split(' ');
                if (s[0] == "End")
                    break;
                else
                    list.Find(x => x.Model == s[1]).Drive(double.Parse(s[2]));
            }
            foreach (Car c in list)
            {
                Console.WriteLine($"{c.Model} {c.FuelAmount:f2} {c.TravelledDistance}");
            }
        }
    }
}
