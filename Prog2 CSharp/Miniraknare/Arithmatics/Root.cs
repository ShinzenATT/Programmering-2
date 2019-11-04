using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Miniraknare.Arithmatics
{
    public class Root : ArithmaticTemplate
    {
        public override double Calculate(double number1, double number2)
        {
            return Math.Pow(number1, 1 / number2);
        }

        public double Calculate(double number)
        {
            return Calculate(number, 2);
        }

        public override double Calculate(double number1, Percentage number2)
        {
            return Math.Pow(number1, (double)number2.GetValue());
        }

        public override double Calculate(Percentage number1, double number2)
        {
            return Calculate((double)number1.GetValue(), number2);
        }
    }
}
