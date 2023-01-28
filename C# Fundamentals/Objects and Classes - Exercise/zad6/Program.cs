using System;
using System.Collections.Generic;

namespace zad6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Vehicle> vehicles = new List<Vehicle>();
            double carhp = 0;
            int cars = 0;
            double truckhp = 0;
            int trucks = 0;
            while (true)
            {
                string[] command = Console.ReadLine().Split(' ');
                if (command.Length == 1)
                {
                    break;
                }
                Vehicle v = new Vehicle();
                if (command[0]=="car")
                {
                    v.type = "Car";
                    carhp += double.Parse(command[3]);
                    cars++;
                }
                else
                {
                    v.type = "Truck";
                    truckhp += double.Parse(command[3]);
                    trucks++;
                }
                v.model= command[1];
                v.color= command[2];
                v.horsepower = double.Parse(command[3]);
                vehicles.Add(v);
            }
            if (trucks!=0)
            {
                truckhp = truckhp / trucks;
            }
            if (cars!=0)
            {
                carhp = carhp / cars;
            }
            while (true)
            {
                string[] command = Console.ReadLine().Split(' ');
                if (command[0] == "Close")
                {
                    Console.WriteLine($"Cars have average horsepower of: {carhp:f2}.");
                    Console.WriteLine($"Trucks have average horsepower of: {truckhp:f2}.");
                    return;
                }
                foreach (Vehicle v in vehicles)
                {
                    if (v.model == command[0])
                    {
                        Console.WriteLine(v);
                    }
                }
            }
        }
    }
    class Vehicle
    {
        public string type { get; set; }
        public string model { get; set; }
        public string color { get; set; }
        public double horsepower { get; set; }

        public override string ToString()
        {
            return $"Type: {type}\nModel: {model}\nColor: {color}\nHorsepower: {horsepower}";
        }
    }
}
