namespace AreaCalculator
{
    public class AreaCalculatorService
    {
        public double GetArea<T>(T shape) where T : IShape
        {
            return shape.GetArea();
        }
    }
}
