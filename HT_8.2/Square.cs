using System;
namespace Test
{
    public class Square : Shape
    {
        private double _side;

        public double Side { get { return _side; } set { _side = value; } }

        public Square(string name, double side) : base(name)
        {
            this._side = side;
        }

        public Square(double side)
        {
            this._side = side;
        }

        public Square()
        {
        }

        public override double Perimeter(double side)
        {
            double squarePerimiter = side * 4;
            return squarePerimiter;
        }

        public override double Area(double side)
        {
            double squareArea = side * side;
            return squareArea;
        }
    }
}
