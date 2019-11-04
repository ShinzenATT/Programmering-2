using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Miniraknare
{
    public abstract class ArithmaticTemplate
    {
        /// <summary>
        /// The base method for calculations
        /// </summary>
        /// <param name="number1"></param>
        /// <param name="number2"></param>
        /// <returns>Result of the calculation between number1 and number2</returns>
        public abstract double Calculate(double number1, double number2);

        public int Calculate(int number1, int number2)
        {
            return (int)Calculate(number1 + 0.0, number2 + 0.0);
        }

        public float Calculate(float number1, float number2)
        {
            return (float) Calculate(number1 + 0.0, number2 + 0.0);
        }

        public short Calculate(short number1, short number2)
        {
            return (short) Calculate(number1 + 0.0, number2 + 0.0);
        }

        public long Calculate(long number1, long number2)
        {
            return (long)Calculate(number1 + 0.0, number2 + 0.0);
        }

        public byte Calculate(byte number1, byte number2)
        {
            return (byte)Calculate(number1 + 0.0, number2 + 0.0);
        }

        public decimal Calculate(decimal number1, decimal number2)
        {
            return (decimal)Calculate((double)number1, (double)number2);
        }

        public Percentage Calculate(Percentage number1, Percentage number2)
        {
            return new Percentage(Calculate(number1.GetValue(), number2.GetValue()));
        }

        /// <summary>
        /// Calculates with a number and a part of a nummber using the percentage (i.e. 20 + (20 * 0.5))
        /// </summary>
        /// <param name="number1">Perentage</param>
        /// <param name="number2">Number</param>
        /// <returns>The result</returns>
        public virtual double Calculate(Percentage number1, double number2)
        {
            return Calculate(((double)number1.GetValue()) * number2, number2);
        }

        /// <summary>
        /// Calculates with a number and a part of a nummber using the percentage (i.e. 20 + (20 * 0.5))
        /// </summary>
        /// <param name="number1">Number</param>
        /// <param name="number2">Percentage</param>
        /// <returns>The result</returns>
        public virtual double Calculate(double number1, Percentage number2)
        {
            return Calculate(number1, ((double)number2.GetValue()) * number1);
        }

        /// <summary>
        /// Finds the appropriate type for the parameters and sends them to the coresponding method
        /// </summary>
        /// <remarks>
        /// If the parameters is not a number type or aligns with the format than this will return null
        /// </remarks>
        /// <param name="value1"></param>
        /// <param name="value2"></param>
        /// <returns>The result from the corosponding method</returns>
        /// <seealso cref="Calculate(double, double)"/>
        public object Calculate(object value1, object value2)
        {
            bool hasCorrectFormat = true;
            object result = null;

            // Checks if it is a percentage and/or a double
            if ((value1.ToString().Contains("%") && value2.GetType() == typeof(double)) ||
                (value1.GetType() == typeof(double) && value2.ToString().Contains("%")))
            {
                string[] values = { value1.ToString(), value2.ToString() };

                if (values[0].Contains("%"))
                {
                    result = Calculate(Percentage.Parse(values[0]), double.Parse(values[1]));
                }
                else if (values[1].Contains("%"))
                {
                    result = Calculate(double.Parse(values[0]), Percentage.Parse(values[1]));
                }

            }
            else if (value1.ToString().Contains("%") && value2.ToString().Contains("%"))
            {
                Percentage num1 = Percentage.Parse(value1.ToString()),
                    num2 = Percentage.Parse(value2.ToString());

                result = Calculate(num1, num2);
            }
            // Checks if both values are the same (primitive) type
            else if (value1.GetType() != value2.GetType())
            {
                    hasCorrectFormat = false;
                
            }
            else
            {
                //Finds out the  datatype of the values and sends them to the appropriate method
                Type valueType = value1.GetType();

                if(valueType == typeof(double)){
                    double num1 = double.Parse(value1.ToString()),
                    num2 = double.Parse(value2.ToString());
                    result = Calculate(num1, num2);
                }
                else if (valueType == typeof(int))
                {
                    int num1 = int.Parse(value1.ToString()),
                    num2 = int.Parse(value2.ToString());
                    result = Calculate(num1, num2);
                }
                else if (valueType == typeof(long))
                {
                    long num1 = long.Parse(value1.ToString()),
                    num2 = long.Parse(value2.ToString());
                    result = Calculate(num1, num2);
                }
                else if (valueType == typeof(short))
                {
                    short num1 = short.Parse(value1.ToString()),
                    num2 = short.Parse(value2.ToString());
                    result = Calculate(num1, num2);
                }
                else if (valueType == typeof(float))
                {
                    float num1 = float.Parse(value1.ToString()),
                    num2 = float.Parse(value2.ToString());
                    result = Calculate(num1, num2);
                }
                else if (valueType == typeof(byte))
                {
                    byte num1 = byte.Parse(value1.ToString()),
                    num2 = byte.Parse(value2.ToString());
                    result = Calculate(num1, num2);
                }
                else
                {
                    hasCorrectFormat = false;
                }

            }

            if (hasCorrectFormat)
            {
                return result;
            }
            else
            {
                return null;
            }
        }
    }
}
