﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CarManufacturer
{
    public class Tire
    {
        int year;
        double pressure;

        public Tire(int year, double pressure)
        {
            Year = year;
            Pressure = pressure;
        }

        public int Year { get => year; set => year = value; }
        public double Pressure { get => pressure; set => pressure = value; }
    }
}
