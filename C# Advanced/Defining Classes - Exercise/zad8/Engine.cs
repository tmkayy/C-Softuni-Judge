using System;
using System.Collections.Generic;
using System.Text;

namespace DefiningClasses
{
    public class Engine
    {
        string model;
        int power;
        int? displacement;
        string efficiency;

        public Engine(string model, int power, int? displacement, string efficiency)
        {
            Model = model;
            Power = power;
            Displacement = displacement;
            Efficiency = efficiency;
        }

        public string Model { get => model; set => model = value; }
        public int Power { get => power; set => power = value; }
        public int? Displacement { get => displacement; set => displacement = value; }
        public string Efficiency { get => efficiency; set => efficiency = value; }

    }
}
