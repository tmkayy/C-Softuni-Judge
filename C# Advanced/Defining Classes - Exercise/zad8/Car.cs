using System;
using System.Collections.Generic;
using System.Text;

namespace DefiningClasses
{
    public class Car
    {
        string model;
        Engine engine;
        int? weight;
        string color;

        public Car(string model, Engine engine, int? weight, string color)
        {
            Model = model;
            Engine = engine;
            Weight = weight;
            Color = color;
        }

        public string Model { get => model; set => model = value; }
        public Engine Engine { get => engine; set => engine = value; }
        public int? Weight { get => weight; set => weight = value; }
        public string Color { get => color; set => color = value; }
    }
}
