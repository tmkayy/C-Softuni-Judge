using System;
using System.Collections.Generic;
using System.Text;

namespace DefiningClasses
{
    public class Cargo
    {
        string type;
        double weight;

        public Cargo(string type, double weight)
        {
            Type = type;
            Weight = weight;
        }

        public string Type { get => type; set => type = value; }
        public double Weight { get => weight; set => weight = value; }
    }
}
