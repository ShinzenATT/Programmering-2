using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Miniraknare
{
    /// <summary>
    /// A subclass that uses <see cref="Calc"/> and has the added functionality of calculation
    /// </summary>
    /// <seealso cref="Calc"/>
    public class CalcExecution : Calc
    {

        /// <summary>
        /// Removes the previous object and a potential arithmatic sign
        /// </summary>
        public override void RemovePreviousObject()
        {
            if (QueryHistory.Last().GetType() == typeof(char))
            {
                QueryHistory.RemoveRange(QueryHistory.Count - 2, 2);
            }
            else
            {
                QueryHistory.RemoveAt(QueryHistory.Count - 1);
            }

        }

        /// <summary>
        /// Stores a value along with a arithmatic sign
        /// </summary>
        /// <param name="number">The value should be stored</param>
        /// <param name="arithmetic">The arithmatic sign that should be used in calculations</param>
        public override void AddItemsToQueryHistory(object number, char arithmetic)
        {
            QueryHistory.Add(number);
            QueryHistory.Add(arithmetic);
        }

        /// <summary>
        /// Storgs a singular value
        /// </summary>
        /// <remarks>The parameter should be thg last number stored otherwise use <see cref="AddItemsToQueryHistory(object, char)"/></remarks>
        /// <param name="number">A value that should be stored</param>
        public void AddItem(object number)
        {
            QueryHistory.Add(number);
        }

        /// <summary>
        /// Calculates all the values using the arithmatic signs provided
        /// </summary>
        /// <returns>The result of the calculations</returns>
        /// <seealso cref="Arithmatics.Addition"/>
        /// <seealso cref="Arithmatics.Subtraction"/>
        /// <seealso cref="Arithmatics.Multiplication"/>
        /// <seealso cref="Arithmatics.Division"/>
        /// <seealso cref="Arithmatics.Root"/>
        public override object Execute()
        {

            char[] letters = { '√', '/', '*', '-', '+' };
            for (int l = 0; l < letters.Length; l++)
            {
                for (int i = 0; i < QueryHistory.Count(); i++)
                {
                    if (QueryHistory[i].GetType() == typeof(char) && QueryHistory[i].Equals(letters[l]))
                    {
                        switch (letters[l])
                        {
                            case '√':
                                QueryHistory[i] = Root.Calculate(QueryHistory[i + 1], QueryHistory[i - 1]);
                                break;
                            case '/':
                                QueryHistory[i] = Division.Calculate(QueryHistory[i - 1], QueryHistory[i + 1]);
                                break;
                            case '*':
                                QueryHistory[i] = Multiplication.Calculate(QueryHistory[i - 1], QueryHistory[i + 1]);
                                break;
                            case '-':
                                QueryHistory[i] = Subtraction.Calculate(QueryHistory[i - 1], QueryHistory[i + 1]);
                                break;
                            case '+':
                                QueryHistory[i] = Addition.Calculate(QueryHistory[i - 1], QueryHistory[i + 1]);
                                break;
                        }

                        QueryHistory.RemoveAt(i + 1);
                        QueryHistory.RemoveAt(i - 1);
                    }
                }
            }
            return QueryHistory[0];
        }

        /// <summary>
        /// Removes all stored values and arithmatic signs
        /// </summary>
        public override void RemoveAll()
        {
            QueryHistory.Clear();
        }
    }
}

