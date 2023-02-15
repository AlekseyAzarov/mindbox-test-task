using System;

namespace AreaCalculator
{
    public class CircleShape : IShape
    {
        private double _radius;

        public CircleShape(double radius)
        {
            if (radius <= 0) throw new ArgumentException("Radius for circle shape is lower or equals zero");

            _radius = radius;
        }

        public double GetArea()
        {
            return Math.PI * Math.Pow(_radius, 2d);
        }
    }
}
