using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    public class Circle : Shape
    {
        private double radius;

        public Circle(double radius)
        {
            Radius = radius;
        }

        public double Radius
        {
            get => radius;
            private set { radius = value; }
        }

        public override double CalculateArea()
        {
            return radius * radius *  Math.PI;
        }

        public override double CalculatePerimeter()
        {
            return 2 * Math.PI * radius;
        }
        public override string Draw()
        {
            return $"Drawing {this.GetType().Name}";
        }
    }
}
