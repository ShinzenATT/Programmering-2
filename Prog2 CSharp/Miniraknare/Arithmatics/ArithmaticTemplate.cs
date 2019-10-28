using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Miniraknare
{
    public abstract class ArithmaticTemplate
    {
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

        public object Calculate(object value1, object value2)
        {
            bool hasCorrectFormat = true;
            object result = null;

            if(value1.GetType() != value2.GetType())
            {
                hasCorrectFormat = false;
            }
            else
            {
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
