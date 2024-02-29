using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicles
{
    public class Bus : Vehicle
    {
        public Bus(double fuelQuantity, double fuelConsumption, double tankCapacity) : base(fuelQuantity, fuelConsumption, tankCapacity)
        {
        }

        public override void Drive(double km)
        {
            base.Drive(km);
        }

        public void DriveFull(double km)
        {
            FuelConsumption += 1.4;
            base.Drive(km);
            FuelConsumption -= 1.4;
        }
    }
}
