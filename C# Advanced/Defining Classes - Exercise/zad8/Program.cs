using System;
using System.Collections.Generic;

namespace DefiningClasses
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Engine> le = new List<Engine>();
            for (int i = 0; i < n; i++)
            {
                string[] s = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
                if (s.Length == 2)
                {
                    Engine e = new Engine(s[0], int.Parse(s[1]), null, null); le.Add(e);
                }
                else if (s.Length == 3)
                {
                    try
                    {
                        Engine e = new Engine(s[0], int.Parse(s[1]), int.Parse(s[2]), null); le.Add(e);
                    }
                    catch { Engine e = new Engine(s[0], int.Parse(s[1]), null, s[2]); le.Add(e); }
                }
                else
                {
                    Engine e = new Engine(s[0], int.Parse(s[1]), int.Parse(s[2]), s[3]); le.Add(e);
                }
            }
            int n2 = int.Parse(Console.ReadLine());
            var lc = new List<Car>();
            for (int i = 0; i < n2; i++)
            {
                string[] s = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
                if (s.Length == 2)
                {
                    Car c = new Car(s[0], le.Find(x => x.Model == s[1]), null, null); lc.Add(c);
                }
                else if (s.Length == 3)
                {
                    try
                    {
                        Car c = new Car(s[0], le.Find(x => x.Model == s[1]), int.Parse(s[2]), null); lc.Add(c);
                    }
                    catch { Car c = new Car(s[0], le.Find(x => x.Model == s[1]), null, s[2]); lc.Add(c); }
                }
                else
                {
                    Car c = new Car(s[0], le.Find(x => x.Model == s[1]), int.Parse(s[2]), s[3]); lc.Add(c);
                }
            }
            foreach (var car in lc)
            {
                Console.WriteLine($"{car.Model}:");
                Console.WriteLine($"  {car.Engine.Model}:");
                Console.WriteLine($"    Power: {car.Engine.Power}");
                Console.WriteLine(car.Engine.Displacement!=null ? $"    Displacement: {car.Engine.Displacement}": $"    Displacement: n/a");
                Console.WriteLine(car.Engine.Efficiency != null ? $"    Efficiency: {car.Engine.Efficiency}" : $"    Efficiency: n/a");
                Console.WriteLine(car.Weight != null ? $"  Weight: {car.Weight}" : $"  Weight: n/a");
                Console.WriteLine(car.Color != null ? $"  Color: {car.Color}" : $"  Color: n/a");
            }
        }
    }
}
