using System;

namespace CarManufacturer
{
    public class Car
    {
        string make;
        string model;
        int year;

        public string Make { get => make; set => make = value; }
        public string Model { get => model; set => model = value; }
        public int Year { get => year; set => year = value; }
    }
}
