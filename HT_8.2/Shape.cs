using System;
namespace Test
{
    public abstract class Shape
    {
        private string _name;
        public string Name { get => _name; }

        public Shape(string name)
        {
            this._name = name;
        }

        public Shape() { }

        public abstract double Area(double value);

        public abstract double Perimeter(double value);
    }
}
