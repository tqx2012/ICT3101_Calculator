using ICT3101_Calculator;
using NUnit.Framework;

namespace ICT3101_Caculator.UnitTests
{
    public class CalculatorTests
    {
        private Calculator _calculator;
        [SetUp]
        public void Setup()
        {
            // Arrange
            _calculator = new Calculator();
        }
        [Test]
        public void Add_WhenAddingTwoNumbers_ResultEqualToSum()
        {
            // Act
            double result = _calculator.Add(10, 20);
            // Assert
            Assert.That(result, Is.EqualTo(30));
        }

        [Test]
        public void Subtract_WhenSubtractingTwoNumberss_ResultEqualToMinus()
        {
            // Act
            double result = _calculator.Subtract(10, 5);
            // Assert
            Assert.That(result, Is.EqualTo(5));
        }

        [Test]
        public void Multiply_WhenMultiplyingTwoNumbers_ResultEqualToTimes()
        {
            // Act
            double result = _calculator.Multiply(10.0, 20.0);
            // Assert
            Assert.That(result, Is.EqualTo(200));
        }

        [Test]
        public void Divide_WhenDividingTwoNumbers_ResultEqualToDiv()
        {
            // Act
            double result = _calculator.Divide(100, 10);
            // Assert
            Assert.That(result, Is.EqualTo(10));
        }


        [Test]
        [TestCase(0, 0)]
        [TestCase(0, 10)]
        [TestCase(10, 0)]
        public void Divide_WithNegativeInputs_ResultThrowArgumentException(int a, int b)
        {
            // Act
            double result = _calculator.Divide(a, b);
            // Assert
            Assert.That(result, Is.EqualTo(double.PositiveInfinity));
        }

        [Test]
        public void AreaOfTriangle()
        {
            // Act
            double result = _calculator.TriangleArea(10, 20);
            // Assert
            Assert.That(result, Is.EqualTo(100));
        }

        [Test]
        public void AreaOfCircle()
        {
            // Act
            double result = _calculator.CircleArea(10);
            // Assert
            Assert.That(result, Is.EqualTo(314.2));
        }

        [Test]
        public void Factorial()
        {
            // Act
            double result = _calculator.Factorial(5);
            // Assert
            Assert.That(result, Is.EqualTo(15625));
        }
    }
}