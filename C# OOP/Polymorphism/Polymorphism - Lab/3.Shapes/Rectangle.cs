using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    public class Rectangle : Shape
    {
        double height;
        double width;

        public Rectangle(double height, double width)
        {
            Height = height;
            Width = width;
        }

        public double Height { get => height; set => height = value; }
        public double Width { get => width; set => width = value; }

        public override double CalculateArea() => Height * Width;

        public override double CalculatePerimeter() => Height * 2 + Width * 2;

        public override string Draw()
        {
            return base.Draw();
        }
    }
}
