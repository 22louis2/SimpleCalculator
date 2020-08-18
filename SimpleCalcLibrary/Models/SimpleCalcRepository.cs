using System;

namespace SimpleCalcLibrary
{
    public class SimpleCalcRepository : ISimpleCalcRepository
    {
        public double Result { get; set; }
        // Implementation of the adding method
        public string Plus(string firstNumber, string secondNumber)
        {
            double[] value = Utility.ToDouble(firstNumber, secondNumber);
            Result = value[0] + value[1];
            return Utility.ToString(Result);
        }

        // Implementation of the subtracting method
        public string Minus(string firstNumber, string secondNumber)
        {
            double[] value = Utility.ToDouble(firstNumber, secondNumber);
            Result = value[0] - value[1];
            return Utility.ToString(Result);
        }

        // Implementation of the multiplying method
        public string Times(string firstNumber, string secondNumber)
        {
            double[] value = Utility.ToDouble(firstNumber, secondNumber);
            Result = value[0] * value[1];
            return Utility.ToString(Result);
        }

        // Implementation of the dividing method
        public string Divide(string firstNumber, string secondNumber)
        {
            if(secondNumber.Equals("0"))
            {
                throw new DivideByZeroException("Number cannot be divided by Zero");
            }
            
            double[] value = Utility.ToDouble(firstNumber, secondNumber);
            Result = value[0] / value[1];
            return Utility.ToString(Result); 

        }

    }
}
