using Calculator2WithXUnitTest;
using Xunit;

namespace Calculator2Test
{
    public class Calc2Test1
    {
        [Fact]
        public void Addition_PositiveNumbers_ReturnsCorrectResult()
        {
            // Arrange
            double num1 = 5;
            double num2 = 3;

            // Act
            double result = Calc.Addition(num1, num2);

            // Assert
            Assert.Equal(8, result);
        }

        [Fact]
        public void Addition_NegativeNumbers_ReturnsCorrectResult()
        {
            // Arrange
            double num1 = -5;
            double num2 = -3;

            // Act
            double result = Calc.Addition(num1, num2);

            // Assert
            Assert.Equal(-8, result);
        }

        [Fact]
        public void Addition_DecimalNumbers_ReturnsCorrectResult()
        {
            // Arrange
            double num1 = 2.5;
            double num2 = 1.5;

            // Act
            double result = Calc.Addition(num1, num2);

            // Assert
            Assert.Equal(4, result);
        }

        [Fact]
        public void Subtraction_PositiveNumbers_ReturnsCorrectResult()
        {
            // Arrange
            double num1 = 5;
            double num2 = 3;

            // Act
            double result = Calc.Subtraction(num1, num2);

            // Assert
            Assert.Equal(2, result);
        }

        [Fact]
        public void Subtraction_NegativeNumbers_ReturnsCorrectResult()
        {
            // Arrange
            double num1 = -5;
            double num2 = -3;

            // Act
            double result = Calc.Subtraction(num1, num2);

            // Assert
            Assert.Equal(-2, result);
        }

        [Fact]
        public void Subtraction_DecimalNumbers_ReturnsCorrectResult()
        {
            // Arrange
            double num1 = 5.5;
            double num2 = 2.3;

            // Act
            double result = Calc.Subtraction(num1, num2);

            // Assert
            Assert.Equal(3.2, result);
        }

        [Fact]
        public void Multiplication_PositiveNumbers_ReturnsCorrectResult()
        {
            // Arrange
            double num1 = 5;
            double num2 = 3;

            // Act
            double result = Calc.Multiplication(num1, num2);

            // Assert
            Assert.Equal(15, result);
        }

        [Fact]
        public void Multiplication_NegativeNumbers_ReturnsCorrectResult()
        {
            // Arrange
            double num1 = -5;
            double num2 = -3;

            // Act
            double result = Calc.Multiplication(num1, num2);

            // Assert
            Assert.Equal(15, result); // The result should be positive due to multiplication of two negative numbers
        }

        [Fact]
        public void Multiplication_DecimalNumbers_ReturnsCorrectResult()
        {
            // Arrange
            double num1 = 2.5;
            double num2 = 1.5;

            // Act
            double result = Calc.Multiplication(num1, num2);

            // Assert
            Assert.Equal(3.75, result);
        }

        [Fact]
        public void Division_PositiveNumbers_ReturnsCorrectResult()
        {
            // Arrange
            double dividend = 6;
            double divisor = 3;

            // Act
            double result = Calc.Division(dividend, divisor);

            // Assert
            Assert.Equal(2, result);
        }

        [Fact]
        public void Division_NegativeNumbers_ReturnsCorrectResult()
        {
            // Arrange
            double dividend = -6;
            double divisor = -3;

            // Act
            double result = Calc.Division(dividend, divisor);

            // Assert
            Assert.Equal(2, result); // The result should be positive due to division of two negative numbers
        }

        [Fact]
        public void Division_DecimalNumbers_ReturnsCorrectResult()
        {
            // Arrange
            double dividend = 3.0;
            double divisor = 1.5;

            // Act
            double result = Calc.Division(dividend, divisor);

            // Assert
            Assert.Equal(2.0, result);
        }

        [Fact]
        public void Division_DivideByZero_ThrowsException()
        {
            // Arrange
            double dividend = 5;
            double divisor = 0;

            // Act & Assert
            Assert.Throws<DivideByZeroException>(() => Calc.Division(dividend, divisor));
        }
    }
}
    

