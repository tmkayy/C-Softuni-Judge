﻿using Cars;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cars
{
    public class Tesla : ICar, IElectricCar
    {
        public Tesla(string model, string color, int battery)
        {
            Model = model;
            Color = color;
            Battery = battery;
        }

        public string Model { get; set; }
        public string Color { get; set; }
        public int Battery { get; set; }

        public string Start()
        {
            throw new NotImplementedException();
        }

        public string Stop()
        {
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.AppendLine($"{this.Color} {GetType().Name} {this.Model} with {this.Battery} Batteries");
            sb.AppendLine($"Engine start");
            sb.AppendLine($"Breaaak!");
            return sb.ToString().Trim();
        }
    }
}
