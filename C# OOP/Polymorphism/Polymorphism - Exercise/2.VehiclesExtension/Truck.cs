using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicles
{
    public class Truck : Vehicle
    {
        public Truck(double fuelQuantity, double fuelConsumption, double tankCapacity) : base(fuelQuantity, fuelConsumption+1.6, tankCapacity)
        {
        }

        public override void Refuel(double fuel)
        {
            if (TankCapacity>=FuelQuantity+fuel)
            {
                if (fuel<=0)
                {
                    Console.WriteLine("Fuel must be a positive number");
                }
                else
                {
                    base.Refuel(fuel * 0.95);
                }
            }
            else
            {
                Console.WriteLine($"Cannot fit {fuel} fuel in the tank");
            }
        }
    }
}
