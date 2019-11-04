using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Miniraknare.Arithmatics
{
    public class Subtraction : ArithmaticTemplate
    {
        /// <summary>
        /// Subtracts the arguments and returns the result
        /// </summary>
        /// <param name="number1">Recieving number</param>
        /// <param name="number2">Attacking number</param>
        /// <returns>The result</returns>
        public override double Calculate(double number1, double number2)
        {
            return number1 - number2;
        }
    }
}
