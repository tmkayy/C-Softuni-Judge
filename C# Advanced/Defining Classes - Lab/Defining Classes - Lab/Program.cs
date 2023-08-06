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
            Console.WriteLine($"Make: {c.Make}\nModel: {c.Model}\nYear: {c.Year}");
        }
    }
}
