using System;
using System.Collections.Generic;
using System.Text;

namespace DefiningClasses
{
    public class Car
    {
        string model;
        double fuelAmount;
        double fuelConsumptionPerKilometer;
        double travelledDistance;

        public Car(string model, double fuelAmount, double fuelConsumptionPerKilometer, double travelledDistance)
        {
            Model = model;
            FuelAmount = fuelAmount;
            FuelConsumptionPerKilometer = fuelConsumptionPerKilometer;
            TravelledDistance = travelledDistance;
        }

        public string Model { get => model; set => model = value; }
        public double FuelAmount { get => fuelAmount; set => fuelAmount = value; }
        public double FuelConsumptionPerKilometer { get => fuelConsumptionPerKilometer; set => fuelConsumptionPerKilometer = value; }
        public double TravelledDistance { get => travelledDistance; set => travelledDistance = value; }

        public void Drive(double km)
        {
            double newthing = this.FuelAmount - km * fuelConsumptionPerKilometer;
            if (newthing < 0)
                Console.WriteLine("Insufficient fuel for the drive");
            else
            {
                this.fuelAmount = newthing; this.TravelledDistance += km;
            }
        }
    }
}
