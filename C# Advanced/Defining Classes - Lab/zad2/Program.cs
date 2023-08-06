using System;

namespace CarManufacturer
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            Car c = new Car();
            c.Make = "VW";
            c.Model = "MK3";
            c.Year = 1992;
            c.FuelQuantity = 200;
            c.FuelConsumption = 200;
            c.Drive(2000);
            Console.WriteLine(c.WhoAmI());
        }
    }
}
