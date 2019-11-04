using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Miniraknare.Arithmatics
{
    public class Root : ArithmaticTemplate
    {
        /// <summary>
        /// Calculates the root of value and returns it
        /// </summary>
        /// <param name="number1">Number</param>
        /// <param name="number2">Amount of roots</param>
        /// <returns>The root</returns>
        public override double Calculate(double number1, double number2)
        {
            return Math.Pow(number1, 1 / number2);
        }

        /// <summary>
        /// Calculates the squareroot of a value
        /// </summary>
        /// <param name="number">Number</param>
        /// <returns>The root</returns>
        /// See also  <seealso cref="Calculate(double, double)"/> for  other roots
        public double Calculate(double number)
        {
            return Calculate(number, 2);
        }

        /// <summary>
        /// See <see cref="Calculate(double, double)"/>
        /// </summary>
        /// <param name="number1"></param>
        /// <param name="number2"></param>
        /// <returns>The root</returns>
        public override double Calculate(double number1, Percentage number2)
        {
            return Math.Pow(number1, (double)number2.GetValue());
        }

        /// <summary>
        /// See <see cref="Calculate(double, double)"/>
        /// </summary>
        /// <param name="number1"></param>
        /// <param name="number2"></param>
        /// <returns>The root</returns>
        public override double Calculate(Percentage number1, double number2)
        {
            return Calculate((double)number1.GetValue(), number2);
        }
    }
}
