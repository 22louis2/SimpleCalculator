using System;

namespace SimpleCalcLibrary
{
    public class SimpleCalcRepository : ISimpleCalcRepository
    {
        // Property Created
        public double Result { get; set; }

        #region IMPLEMENTATION OF THE ADDING METHOD
        // Implementation of the adding method
        public string Plus(string firstNumber, string secondNumber)
        {
            // Using the utility class to convert my parameter string to double array
            double[] value = Utility.ToDouble(firstNumber, secondNumber);
            // Adding the returned array index
            Result = value[0] + value[1];
            // Returning the added arrays as strings
            return Utility.ToString(Result);
        }
        #endregion

        #region IMPLEMENTATION OF THE SUBTRACTING METHOD
        // Implementation of the subtracting method
        public string Minus(string firstNumber, string secondNumber)
        {
            // Using the utility class to convert my parameter string to double array
            double[] value = Utility.ToDouble(firstNumber, secondNumber);
            // Subtracting the returned array index
            Result = value[0] - value[1];
            // Returning the subtracted arrays as strings
            return Utility.ToString(Result);
        }
        #endregion

        #region IMPLEMENTATION OF THE MULTIPLYING METHOD
        // Implementation of the multiplying method
        public string Times(string firstNumber, string secondNumber)
        {
            // Using the utility class to convert my parameter string to double array
            double[] value = Utility.ToDouble(firstNumber, secondNumber);
            // Multiply the returned array index
            Result = value[0] * value[1];
            // Returning the multiplied arrays as strings
            return Utility.ToString(Result);
        }
        #endregion

        #region IMPLEMENTATION OF THE DIVIDING METHOD
        // Implementation of the dividing method
        public string Divide(string firstNumber, string secondNumber)
        {
            /* 
             * Checking if the second value is zero
             * Throw an error if it is zero
            */
            if(secondNumber.Equals("0"))
            {
                throw new DivideByZeroException("Number cannot be divided by Zero");
            }

            // Using the utility class to convert my parameter string to double array
            double[] value = Utility.ToDouble(firstNumber, secondNumber);
            // Divide the returned array index
            Result = value[0] / value[1];
            // Returning the divided arrays as strings
            return Utility.ToString(Result); 

        }
        #endregion

        #region IMPLEMENTATION OF THE EQUALITY METHOD
        // Implementing The Equality sign
        public string Equality (string operation, string firstNumber, string secondNumber)
        {
            string result = "";
            switch (operation)
            {
                // Checking the various type of operators passed
                case "+":
                    // Pass to the Plus method if it's a "+" sign
                    result = Plus(firstNumber, secondNumber);
                    break;
                case "-":
                    // Pass to the Minus method if it's a "-" sign
                    result = Minus(firstNumber, secondNumber);
                    break;
                case "*":
                    // Pass to the Times method if it's a "*" sign
                    result = Times(firstNumber, secondNumber);
                    break;
                case "/":
                    // Pass to the Divide method if it's a "/" sign
                    result = Divide(firstNumber, secondNumber);
                    break;
                default:
                    break;
            }

            // Return the result of the operation performed
            return result;
        }
        #endregion

    }
}
