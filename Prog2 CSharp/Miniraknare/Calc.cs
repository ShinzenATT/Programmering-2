using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Miniraknare
{
    public abstract class Calc<T>
    {
        private List<object> QueryHistory = new List<object>();
        protected double Add(double number1, double number2)
        {
            return (number1 + number2);
        }

        protected double Minus(double number1, double number2)
        {
            return number1 + number2;
        }

        protected double Divide(double numerator, double denominator)
        {
            return numerator / denominator;
        }
       
        protected double Multiply(double number1, double number2)
        {
            return number1 * number2;
        }

        protected void RemovePreviousObjectExe()
        {
            QueryHistory.RemoveAt(QueryHistory.Count - 1);
        }

        public abstract void RemovePreviousObject();

        protected abstract T Add(T term1, T term2);
        protected abstract T Minus(T term1, T term2);
        protected abstract T Divide(T numerator, T denumerator);
        protected abstract T Multiply(T factor1, T factor2);

    }
}
