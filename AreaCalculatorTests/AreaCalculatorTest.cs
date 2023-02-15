using AreaCalculator;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace AreaCalculatorTests
{
    [TestClass]
    public class AreaCalculatorTest
    {
        [TestMethod]
        public void CircleShapeTest()
        {
            var expectedArea = 314.15926535d;
            var accepatableDelta = 0.00000001;
            var calculatorService = new AreaCalculatorService();
            var circleShape = new CircleShape(10f);
            var actualArea = calculatorService.GetArea(circleShape);
            Assert.AreEqual(expectedArea, actualArea, accepatableDelta);
        }

        [TestMethod]
        public void TriangleShapeTest()
        {
            var expectedArea = 11.97654d;
            var accepatableDelta = 0.0001d;
            var calculatorService = new AreaCalculatorService();
            var triangleShape = new TriangleShape(4d, 6d, 7d);
            var actualArea = calculatorService.GetArea(triangleShape);
            Assert.AreEqual(expectedArea, actualArea, accepatableDelta);
        }

        [TestMethod]
        public void RightAngledTriangleShapeTest()
        {
            var expectedArea = 120d;
            var accepatableDelta = 0.0001d;
            var calculatorService = new AreaCalculatorService();
            var triangleShape = new TriangleShape(26d, 10d, 24d);
            var actualArea = calculatorService.GetArea(triangleShape);
            Assert.IsTrue(triangleShape.IsRightAngled());
            Assert.AreEqual(expectedArea, actualArea, accepatableDelta);
        }
    }
}
