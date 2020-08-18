using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleCalcLibrary
{
    public class Utility
    {
        public static string ToString(double num)
        {
            return num.ToString();
        }

        public static double[] ToDouble(string num1, string num2)
        {
            double[] result = new double[] { double.Parse(num1), double.Parse(num2) };
            return result;
        }
    }
}
