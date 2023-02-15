using System;

namespace AreaCalculator
{
    public class TriangleShape : IShape
    {
        private double _sideA;
        private double _sideB;
        private double _sideC;
        private double _angleA;
        private double _angleB;
        private double _angleC;

        public TriangleShape(double sideA, double sideB, double sideC)
        {
            if (sideA + sideB <= sideC
                || sideA + sideC <= sideB
                || sideB + sideC <= sideA) throw new ArgumentException("Sides of a triangle is invalid");

            _sideA = sideA;
            _sideB = sideB;
            _sideC = sideC;

            var angleACos = (Math.Pow(sideA, 2d) + Math.Pow(sideC, 2d) - Math.Pow(sideB, 2d)) / (2 * sideA * sideC);
            _angleA = Math.Acos(angleACos);
            var angleBCos = (Math.Pow(sideA, 2d) + Math.Pow(sideB, 2d) - Math.Pow(sideC, 2d)) / (2 * sideA * sideB);
            _angleB = Math.Acos(angleBCos);
            var angleCCos = (Math.Pow(sideB, 2d) + Math.Pow(sideC, 2d) - Math.Pow(sideA, 2d)) / (2 * sideC * sideB);
            _angleC = Math.Acos(angleCCos);
        }

        public double GetArea()
        {
            var isRightAngled = IsRightAngled();
            return isRightAngled ? GetAreaForRightAngled() : GetAreaForNotRightAngled();
        }

        public bool IsRightAngled()
        {
            return _angleA * (180d / Math.PI) == 90d 
                || _angleB * (180d / Math.PI) == 90d 
                || _angleC * (180d / Math.PI) == 90d;
        }

        private double GetAreaForRightAngled()
        {
            var hypotenuse = Math.Max(_sideA, Math.Max(_sideB, _sideC));
            var sharpAngle = Math.Min(_angleA, Math.Min(_angleB, _angleC));
            return Math.Pow(hypotenuse, 2d) * Math.Sin(sharpAngle) * Math.Cos(sharpAngle) / 2;
        }

        public double GetAreaForNotRightAngled()
        {
            var semiPerimeter = (_sideA + _sideB + _sideC) / 2;
            return Math.Sqrt(semiPerimeter * (semiPerimeter - _sideA) * (semiPerimeter - _sideB) * (semiPerimeter - _sideC));
        }
    }
}
