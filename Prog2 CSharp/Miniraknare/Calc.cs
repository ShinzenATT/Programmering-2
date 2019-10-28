using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Miniraknare
{
    public abstract class Calc<T>
    {
        protected List<object> QueryHistory = new List<object>();

        public override string ToString()
        {
            string result = "";

            for(int i = 0; i < QueryHistory.Count; i++)
            {
                result += QueryHistory[i].ToString() + " ";
            }

            return result;
        }

        protected void AddObjectToList(object target)
        {
            QueryHistory.Add(target);
        }

        public abstract void AddItemsToQueryHistory(object number, char arithmetic);

        protected void RemovePreviousObjectExe()
        {
            QueryHistory.RemoveAt(QueryHistory.Count - 1);
        }

        public abstract void RemovePreviousObject();

        public abstract void RemoveAll();

        protected abstract object SignCheck(char sign, int signIndex);

        public double Add(double number1, double number2)
        {
            return (number1 + number2);
        }

        public double Minus(double number1, double number2)
        {
            return number1 + number2;
        }

        public double Divide(double numerator, double denominator)
        {
            return numerator / denominator;
        }
       
        public double Multiply(double number1, double number2)
        {
            return number1 * number2;
        }

        public abstract T Add(T term1, T term2);
        public abstract T Minus(T term1, T term2);
        public abstract T Divide(T numerator, T denumerator);
        public abstract T Multiply(T factor1, T factor2);

        public abstract object Execute();

    }
}
