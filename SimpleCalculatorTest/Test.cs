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
            string expected = res.Plus(firstNumber, secondNumber);
            string actual = "12";

            // Assert
            Assert.Equal(expected, actual);
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
            string expected = res.Minus(firstNumber, secondNumber);
            string actual = "7";

            // Assert
            Assert.Equal(expected, actual);
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
            string expected = res.Times(firstNumber, secondNumber);
            string actual = "72";

            // Assert
            Assert.Equal(expected, actual);
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
            string expected = res.Divide(firstNumber, secondNumber);
            string actual = "5";

            // Assert
            Assert.Equal(expected, actual);
        }
        #endregion

        #region CHECKING ERROR GOTTEN FROM DIVIDING BY ZERO
        /* Checking if the user tries to divide by 0
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
