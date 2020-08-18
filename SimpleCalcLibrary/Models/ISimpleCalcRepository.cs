using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleCalcLibrary
{
    public interface ISimpleCalcRepository
    {
        public string Plus(string firstNumber, string secondNumber);
        public string Minus(string firstNumber, string secondNumber);
        public string Times(string firstNumber, string secondNumber);
        public string Divide(string firstNumber, string secondNumber);
    }
}
