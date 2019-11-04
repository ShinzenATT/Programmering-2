using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Miniraknare.Arithmatics
{
    public class Multiplication : ArithmaticTemplate
    {
        /// <summary>
        /// Multiplies the arguments and returrns the product
        /// </summary>
        /// <param name="number1">Number</param>
        /// <param name="number2">Number</param>
        /// <returns>Product of the two arguments</returns>
        public override double Calculate(double number1, double number2)
        {
            return number1 * number2;
        }

        /// <summary>
        /// Unlike <see cref="ArithmaticTemplate.Calculate(double, Percentage)"/> this one directly multiplies with the values
        /// </summary>
        /// <param name="number1">Number</param>
        /// <param name="number2">Percentage</param>
        /// <returns>The product</returns>
        public override double Calculate(Percentage number1, double number2)
        {
            return Calculate(((double)number1.GetValue()), number2);
        }

        /// <summary>
        /// Unlike <see cref="ArithmaticTemplate.Calculate(double, Percentage)"/> this one directly multiplies with the values
        /// </summary>
        /// <param name="number1">Percentage</param>
        /// <param name="number2">Number</param>
        /// <returns>The product</returns>
        public override double Calculate(double number1, Percentage number2)
        {
            return Calculate(number1, ((double)number2.GetValue()));
        }

    }
}
