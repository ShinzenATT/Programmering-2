using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Miniraknare
{
    /// <summary>
    /// A base class for storing values such as numbers and arithmatic signs and using them in calculations
    /// </summary>
    public abstract class Calc : ArithmaticWielding
    {
        /// <summary>
        /// This list stores all values in <see cref="Calc"/>
        /// </summary>
        protected List<object> QueryHistory = new List<object>();

        /// <summary>
        /// Turns the list into a string with spaces and values made into string
        /// </summary>
        /// <returns> A formated string made for display </returns>
        public override string ToString()
        {
            string result = "";

            for(int i = 0; i < QueryHistory.Count; i++)
            {
                result += QueryHistory[i].ToString() + " ";
            }

            return result;
        }

        /// <summary>
        /// Storgs a singular value
        /// </summary>
        /// <remarks>The parameter should be a number otherwise use <see cref="AddItemsToQueryHistory(object, char)"/></remarks>
        /// <param name="target">A value that should be stored</param>
        protected void AddObjectToList(object target)
        {
            QueryHistory.Add(target);
        }

        /// <summary>
        /// Stores a value along with a arithmatic sign
        /// </summary>
        /// <param name="number">The that should be stored</param>
        /// <param name="arithmetic">The arithmatic sign that should be used in calculations</param>
        public abstract void AddItemsToQueryHistory(object number, char arithmetic);

        /// <summary>
        /// Removes the lastes objects that was stored
        /// </summary>
        public abstract void RemovePreviousObject();

        /// <summary>
        /// Removes all everything that is stored
        /// </summary>
        public abstract void RemoveAll();

        /// <summary>
        /// Calculates all values that is stored
        /// </summary>
        /// <returns>The result of all calculations</returns>
        public abstract object Execute();

    }
}
