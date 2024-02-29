using System;
using System.Collections.Generic;
using System.Text;

namespace NeedForSpeed
{
    public class Vehicle
    {
        int horsePower;
        double fuel;
        double defaultFuelConsumption = 1.25;
        double fuelConsumption;

        public Vehicle(int horsePower, double fuel)
        {
            HorsePower = horsePower;
            Fuel = fuel;
        }

        public int HorsePower { get => horsePower; set => horsePower = value; }
        public double Fuel { get => fuel; set => fuel = value; }
        public double DefaultFuelConsumption { get => defaultFuelConsumption; set => defaultFuelConsumption = value; }
        public virtual double FuelConsumption { get => DefaultFuelConsumption; set => fuelConsumption = DefaultFuelConsumption; }

        public virtual void Drive(double kilometers)
        {
            Fuel -= kilometers*FuelConsumption;
        }
    }
}
