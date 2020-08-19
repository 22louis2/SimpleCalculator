using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleCalcLibrary
{
    public class Utility
    {
        // Utility Class to convert a double to string 
        public static string ToString(double num)
        {
            return num.ToString();
        }

        // Utility class to convert two string to a double array
        public static double[] ToDouble(string num1, string num2)
        {
            double[] result = new double[] { double.Parse(num1), double.Parse(num2) };
            return result;
        }
    }
}
