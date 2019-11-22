using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace v47___Solid
{
    interface ICalculation<T>
    {
        char Sign { get; }

        T DoOperation(T num1, T num2);

        bool ContainsSign(string str);
        bool ContainsSign(char letter);
    }
}
