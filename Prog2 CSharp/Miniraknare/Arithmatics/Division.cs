using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Miniraknare.Arithmatics
{
    public class Division : ArithmaticTemplate
    {
        /// <summary>
        /// Divides the arguments and returns the result
        /// </summary>
        /// <param name="number1">Numerator</param>
        /// <param name="number2">Denominator</param>
        /// <returns>Result of the calculation</returns>
        public override double Calculate(double number1, double number2)
        {
            return number1 / number2;
        }
    }
}
