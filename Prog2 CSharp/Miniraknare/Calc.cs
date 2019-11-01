using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Miniraknare
{
    public abstract class Calc : ArithmaticWielding
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

        public abstract object Execute();

    }
}
