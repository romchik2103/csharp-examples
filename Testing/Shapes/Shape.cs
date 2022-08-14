using System;

namespace Testing.Shapes
{
    public interface IShape
    {
        public double Area { get; }
        public double Perimeter { get; }
    }

    public interface IPoint
    {
        public double X { get; }
        public double Y { get; }
    }

    public abstract class Shape : IShape, IPoint
    {
        private double _x;
        private double _y;

        public double X => _x;
        public double Y => _y;

        public abstract double Area { get; }
        public abstract double Perimeter { get; }

        protected Shape(double x, double y)
        {
            _x = x;
            _y = y;
        }
    }
}