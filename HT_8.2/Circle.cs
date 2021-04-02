using System;
namespace Test
{
    public class Circle : Shape
    {
        private double _radius;

        public double Radius { get { return _radius; } set { _radius = value; } }

        public Circle(string name, double radius) : base(name)
        {
            this._radius = radius;
        }

        public Circle(double radius)
        {
            this._radius = radius;
        }

        public Circle()
        {
        }

        public override double Area(double radius)
        {
            double circleArea = radius * 3.14;
            return circleArea;
        }

        public override double Perimeter(double radius)
        {
            double circlePerimeter = 2 * 3.14 * radius;
            return circlePerimeter;
        }
    }
}