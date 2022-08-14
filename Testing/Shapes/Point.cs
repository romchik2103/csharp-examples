namespace Testing.Shapes
{
    public class Point : IPoint
    {
        public Point(double x, double y)
        {
            Y = y;
            X = x;
        }

        public double X { get; }
        public double Y { get; }

        public override string ToString()
        {
            return $"({X}, {Y})";
        }
    }
}