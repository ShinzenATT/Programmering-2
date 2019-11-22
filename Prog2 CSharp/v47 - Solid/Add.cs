using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace v47___Solid
{
    class Add : ICalculation<double>
    {
        public char Sign { get; } = '+';

        public bool ContainsSign(string str)
        {
            return str.Contains(Sign);
        }

        public bool ContainsSign(char letter)
        {
            return letter == Sign;
        }

        public double DoOperation(double num1, double num2)
        {
            return num1 + num2;
        }
    }
}
