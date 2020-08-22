using System;
using Xunit;
using SimpleCalcLibrary;

namespace SimpleCalculatorTest
{
    public class Test
    {
        #region CHECKING ADDITION METHOD
        // Checking if the result gotten is as expected
        [Fact]
        public void CheckingAddition()
        {
            // Arrange
            string firstNumber = "5";
            string secondNumber = "7";
            SimpleCalcRepository res = new SimpleCalcRepository();

            // Act
            string actual = res.Plus(firstNumber, secondNumber);
            string expected = "12";

            // Assert
            Assert.Equal(actual, expected);
        }
        #endregion

        #region CHECKING SUBTRACTION METHOD
        // Checking if result is same as expected
        [Fact]
        public void CheckingSubtraction()
        {
            // Arrange
            string firstNumber = "15";
            string secondNumber = "8";
            SimpleCalcRepository res = new SimpleCalcRepository();

            // Act
            string actual = res.Minus(firstNumber, secondNumber);
            string expected = "7";

            // Assert
            Assert.Equal(actual, expected);
        }
        #endregion

        #region CHECKING MULTIPLICATION METHOD
        // Checking if the result for multiplying is same as expected
        [Fact]
        public void CheckingMultiplication()
        {
            // Arrange
            string firstNumber = "9";
            string secondNumber = "8";
            SimpleCalcRepository res = new SimpleCalcRepository();

            // Act
            string actual = res.Times(firstNumber, secondNumber);
            string expected = "72";

            // Assert
            Assert.Equal(actual, expected);
        }
        #endregion

        #region CHECKING DIVISION METHOD
        // Checking if the result is as expected
        [Fact]
        public void CheckingDivision()
        {
            // Arrange
            string firstNumber = "25";
            string secondNumber = "5";
            SimpleCalcRepository res = new SimpleCalcRepository();

            // Act
            string actual = res.Divide(firstNumber, secondNumber);
            string expected = "5";

            // Assert
            Assert.Equal(actual, expected);
        }
        #endregion

        #region CHECKING ERROR GOTTEN FROM DIVIDING BY ZERO
        /* Checking if the user tries to divide first number by 0
         * Throw an error
        */
        [Fact]
        public void DividingByZeroException()
        {
            // Arrange
            string firstNumber = "25";
            string secondNumber = "0";
            SimpleCalcRepository res = new SimpleCalcRepository();

            // Assert
            Assert.Throws<DivideByZeroException>(() =>
                res.Divide(firstNumber, secondNumber)
            );
        }
        #endregion
    }
}
