using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicles
{
    public class Truck : Vehicle
    {
        public Truck(double fuelQuantity, double fuelConsumption) : base(fuelQuantity, fuelConsumption + 1.6)
        {
        }

        public override void Refuel(double fuel)
        {
            base.Refuel(fuel*0.95);
        }
    }
}
