using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Miniraknare
{
    public class Percentage
    {
        private decimal percent = 0;

        public Percentage(decimal value, bool isInDecimals)
        {
            if (isInDecimals)
            {
                percent = value;
            }
            else
            {
                percent = value / 100;
            }
        }

        public Percentage(decimal value)
        {
            percent = value;
        }

        public decimal GetValue()
        {
            return percent;
        }

        public override string ToString()
        {
            return (percent * 100 ).ToString() + '%';
        }

        public static Percentage Parse(String str)
        {
            bool isInDecimals = true;
            if (str.Contains("%"))
            {
                str = str.Replace("%", "");
                isInDecimals = false;
            }

            decimal result = 0;

            try
            {
                result = decimal.Parse(str);
            }
            catch
            {
                result = 0;
            }

            if (!isInDecimals)
            {
                result /= 100;
            }

            return new Percentage(result);
        }

        public static Percentage operator+ (Percentage var1, Percentage var2)
        {
            return new Percentage(var1.GetValue() + var2.GetValue());
        }

        public static double operator +(Percentage var1, double var2)
        {
            return (((double)var1.GetValue()) * var2) + var2;
        }

        public static double operator +(double var1, Percentage var2)
        {
            return (((double)var2.GetValue()) * var1) + var1;
        }

        public static Percentage operator- (Percentage var1, Percentage var2)
        {
            return new Percentage(var1.GetValue() - var2.GetValue());
        }

        public static double operator -(Percentage var1, double var2)
        {
            return (((double)var1.GetValue()) * var2) - var2;
        }

        public static double operator -(double var1, Percentage var2)
        {
            return var1 - (((double)var2.GetValue()) * var1);
        }

        public static Percentage operator* (Percentage var1, Percentage var2)
        {
            return new Percentage(var1.GetValue() * var2.GetValue());
        }

        public static double operator *(Percentage var1, double var2)
        {
            return ((double)var1.GetValue()) * var2;
        }

        public static double operator *(double var1, Percentage var2)
        {
            return ((double)var2.GetValue()) * var1;
        }

        public static Percentage operator/ (Percentage var1, Percentage var2)
        {
            return new Percentage(var1.GetValue() / var2.GetValue());
        }

        public static double operator /(Percentage var1, double var2)
        {
            return (((double)var1.GetValue()) * var2) / var2;
        }

        public static double operator /(double var1, Percentage var2)
        {
            return var1 / (((double)var2.GetValue()) * var1);
        }

    }
}
