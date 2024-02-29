using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Vehicles
{
    public abstract class Vehicle
    {
        double fuelQuantity;
        double fuelConsumption;
        double tankCapacity;

        protected Vehicle(double fuelQuantity, double fuelConsumption, double tankCapacity)
        {
            FuelQuantity = fuelQuantity;
            FuelConsumption = fuelConsumption;
            if (fuelQuantity <= tankCapacity)
            {
                TankCapacity = tankCapacity;
            }
            else
            {
                FuelQuantity = 0;
            }
        }

        public double FuelQuantity { get => fuelQuantity; set => fuelQuantity = value; }
        public double FuelConsumption { get => fuelConsumption; set => fuelConsumption = value; }
        public double TankCapacity { get => tankCapacity; set => tankCapacity = value; }

        public virtual void Drive(double km)
        {
            double f = FuelQuantity - km * FuelConsumption;
            if (f > 0)
            {
                FuelQuantity = f;
                Console.WriteLine($"{this.GetType().Name} travelled {km} km");
            }
            else
            {
                Console.WriteLine($"{this.GetType().Name} needs refueling");
            }
        }
        public virtual void Refuel(double fuel)
        {
            if (fuel <= 0)
            {
                Console.WriteLine("Fuel must be a positive number");
            }
            else
            {
                if (TankCapacity >= FuelQuantity + fuel)
                    FuelQuantity += fuel;
                else
                    Console.WriteLine($"Cannot fit {fuel} fuel in the tank");
            }
        }
        public override string ToString() => $"{this.GetType().Name}: {FuelQuantity:f2}";
    }
}
