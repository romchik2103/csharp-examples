using System;

namespace Testing.Shapes
{
    public class Square : Shape
    {
        public override double Area => _side * _side;
        public override double Perimeter => _side * 4;
        
        private double _side;
        
        public Square(double side, double x, double y) : base(x, y)
        {
            _side = side;
        }

        public override string ToString()
        {
            return $"Square(side = {_side}, area = {Area}, perimeter = {Perimeter})";
        }
    }
}