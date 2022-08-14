using System;
using System.Collections.Generic;
using Minecraft;
using Testing.Shapes;

namespace Testing
{
    class Program
    {
        private static Random _rand = new();
        private static List<Entity> _globalEntities = new();

        static void Main()
        {
            List<IPoint> shapes = new();
            var circle = new Circle(5, 1, 1);
            var square = new Square(2, -5, -5);
            var point = new Point(-1, 4);
            var point2 = new Point(10, 2);
            shapes.Add(circle);
            shapes.Add(square);
            shapes.Add(point);
            shapes.Add(point2);

            Console.WriteLine(CalculateCenter(shapes));
        }

        private static void SpawnRandomMob()
        {
            var r = _rand.Next(0, 3);

            if (r == 0)
                _globalEntities.Add(new Mob("Zombie", 10, 15));
            else if (r == 1)
                _globalEntities.Add(new Mob("Skeleton", 11, 10));
            else if (r == 2)
                _globalEntities.Add(new Mob("Spider", 12, 10));
        }

        private static void DespawnAll()
        {
            foreach (var entity in _globalEntities)
            {
                entity.Destroy();
            }
        }

        private static Point CalculateCenter(List<IPoint> points)
        {
            double xSum = 0;
            double ySum = 0;

            foreach (var point in points)
            {
                xSum += point.X;
                ySum += point.Y;
            }

            var count = points.Count;

            return new Point(xSum / count, ySum / count);
        }
    }
}