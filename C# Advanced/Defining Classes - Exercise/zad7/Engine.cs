using System;
using System.Collections.Generic;
using System.Text;

namespace DefiningClasses
{
    public class Engine
    {
        double speed;
        double power;

        public Engine(double speed, double power)
        {
            Speed = speed;
            Power = power;
        }

        public double Speed { get => speed; set => speed = value; }
        public double Power { get => power; set => power = value; }
    }
}
