using System;
using System.Collections.Generic;
using System.Text;

namespace DefiningClasses
{
    public class Tire
    {
        double age;
        double pressure;

        public Tire(double age, double pressure)
        {
            Age = age;
            Pressure = pressure;
        }

        public double Age { get => age; set => age = value; }
        public double Pressure { get => pressure; set => pressure = value; }
    }
}
