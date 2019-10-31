using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Miniraknare.Arithmatics
{
    public class Multiplication : ArithmaticTemplate
    {
        public override double Calculate(double number1, double number2)
        {
            return number1 * number2;
        }

        public override double Calculate(Percentage number1, double number2)
        {
            return Calculate(((double)number1.GetValue()), number2);
        }

        public override double Calculate(double number1, Percentage number2)
        {
            return Calculate(number1, ((double)number2.GetValue()));
        }

    }
}
