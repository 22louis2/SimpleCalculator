using System;
using Xunit;
using SimpleCalcLibrary;

namespace SimpleCalculatorTest
{
    public class Test
    {
        [Fact]
        public void CheckingAddition()
        {
            // Arrange
            string firstNumber = "5";
            string secondNumber = "7";
            SimpleCalcRepository res = new SimpleCalcRepository();

            // Act
            string expected = res.Plus(firstNumber, secondNumber);
            string actual = "12";

            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void CheckingSubtraction()
        {
            // Arrange
            string firstNumber = "15";
            string secondNumber = "8";
            SimpleCalcRepository res = new SimpleCalcRepository();

            // Act
            string expected = res.Minus(firstNumber, secondNumber);
            string actual = "7";

            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void CheckingMultiplication()
        {
            // Arrange
            string firstNumber = "9";
            string secondNumber = "8";
            SimpleCalcRepository res = new SimpleCalcRepository();

            // Act
            string expected = res.Times(firstNumber, secondNumber);
            string actual = "72";

            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void CheckingDivision()
        {
            // Arrange
            string firstNumber = "25";
            string secondNumber = "5";
            SimpleCalcRepository res = new SimpleCalcRepository();

            // Act
            string expected = res.Divide(firstNumber, secondNumber);
            string actual = "5";

            // Assert
            Assert.Equal(expected, actual);
        }
    }
}
