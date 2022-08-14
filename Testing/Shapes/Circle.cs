using System;

namespace Testing.Shapes
{
    public class Circle : Shape
    {
        public override double Area => Math.PI * _radius * _radius;
        public double Circumference => 2d * Math.PI * _radius;
        public override double Perimeter => Circumference;
        
        private int _radius;

        public Circle(int radius, double x, double y) : base(x, y)
        {
            _radius = radius;
        }

        public override string ToString()
        {
            return $"Circle(radius = {_radius}, area = {Area}, circumference = {Circumference})";
        }
    }
}