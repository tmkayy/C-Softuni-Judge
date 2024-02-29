using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    public class Circle : Shape
    {
        double radius;

        public Circle(double radius)
        {
            Radius = radius;
        }

        public double Radius { get => radius; set => radius = value; }

        public override double CalculateArea() => Radius*Radius*Math.PI;

        public override double CalculatePerimeter() => 2 * Radius * Math.PI;

        public override string Draw()
        {
            return base.Draw();
        }
    }
}
