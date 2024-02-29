using System;
using System.Collections.Generic;
using System.Text;

namespace ClassBoxData
{
    public class Box
    {
        double length;
        double width;
        double height;

        public Box(double length, double width, double height)
        {
            Length = length;
            Width = width;
            Height = height;
        }

        public double Length
        {
            get => length; private set
            {
                if (value > 0)
                {
                    length = value;
                }
                else
                {
                    throw new ArgumentException($"Length cannot be zero or negative.");
                }
            }
        }
        public double Width
        {
            get => width; private set
            {
                if (value > 0)
                {
                    width = value;
                }
                else
                {
                    throw new ArgumentException($"Width cannot be zero or negative.");
                }
            }
        }
        public double Height
        {
            get => height; private set
            {
                if (value > 0)
                {
                    height = value;
                }
                else
                {
                    throw new ArgumentException($"Height cannot be zero or negative.");
                }
            }
        }

        public double SurfaceArea()
        { return 2 * Length * Width + 2 * Length * Height + 2 * Width * Height; }

        public double LateralSurfaceArea() => 2 * Length * Height + 2 * Width * Height;

        public double Volume() => Length * Width * Height;
    }
}
