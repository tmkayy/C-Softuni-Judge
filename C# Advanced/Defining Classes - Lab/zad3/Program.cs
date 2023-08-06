using System;

namespace CarManufacturer
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            string make = Console.ReadLine();
            string model = Console.ReadLine();
            int year = int.Parse(Console.ReadLine());
            double fuelQuanity = double.Parse(Console.ReadLine());
            double fuelConsumption = double.Parse(Console.ReadLine());
            Car c1 = new Car();
            Car c2 = new Car(make, model, year);
            Car c3 = new Car(make, model, year, fuelQuanity, fuelConsumption);
        }
    }
}
