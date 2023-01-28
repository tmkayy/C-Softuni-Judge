using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace zad7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Catalog catalog = new Catalog();
            while (true)
            {
                string[] vehicle = Console.ReadLine().Split('/').ToArray();
                if (vehicle[0] == "end")
                {
                    break;
                }
                else if (vehicle[0] == "Car")
                {
                    Car car = new Car();
                    car.Brand = vehicle[1];
                    car.Model = vehicle[2];
                    car.HP = vehicle[3];
                    catalog.Cars.Add(car);
                }
                else
                {
                    Truck truck = new Truck();
                    truck.Brand = vehicle[1];
                    truck.Model = vehicle[2];
                    truck.Weight = vehicle[3];
                    catalog.Trucks.Add(truck);
                }
            }
            if (catalog.Cars.Any())
            {
                Console.WriteLine("Cars:");
                foreach (Car car in catalog.Cars.OrderBy(c => c.Brand))
                {
                    Console.WriteLine(car);
                }
            }
            if (catalog.Trucks.Any())
            {
                Console.WriteLine("Trucks:");
                foreach (Truck truck in catalog.Trucks.OrderBy(t => t.Brand))
                {
                    Console.WriteLine(truck);
                }
            }
        }
        class Truck
        {
            public string Brand { get; set; }
            public string Model { get; set; }
            public string Weight { get; set; }
            public override string ToString()
            {
                return $"{this.Brand}: {this.Model} - {this.Weight}kg";
            }
        }
        class Car
        {
            public string Brand { get; set; }
            public string Model { get; set; }
            public string HP { get; set; }
            public override string ToString()
            {
                return $"{this.Brand}: {this.Model} - {this.HP}hp";
            }
        }
        class Catalog
        {
            public List<Truck> Trucks { get; set; }
            public List<Car> Cars { get; set; }
            public Catalog()
            {
                Trucks = new List<Truck>();
                Cars = new List<Car>();
            }
        }
    }
}
