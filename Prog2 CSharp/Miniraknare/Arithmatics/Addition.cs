using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Miniraknare.Arithmatics
{
    public class Addition : ArithmaticTemplate
    {
        /// <summary>
        /// Adds the two  arguments together and returns the sum
        /// </summary>
        /// <param name="number1">Number</param>
        /// <param name="number2">Number</param>
        /// <returns>The sum of the calculation</returns>
        public override double Calculate(double number1, double number2)
        {
            return number1 + number2;
        }
    }
}
