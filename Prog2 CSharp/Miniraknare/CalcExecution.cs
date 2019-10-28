using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Miniraknare
{
    public class CalcExecution : Calc<object>
    {
        public override void RemovePreviousObject()
        {
            if (QueryHistory.Last().GetType().ToString().Equals("char"))
            {
                QueryHistory.RemoveRange(QueryHistory.Count - 2, 2);
            }
            else
            {
                QueryHistory.RemoveAt(QueryHistory.Count - 1);
            }
        }

        public override object Add(object term1, object term2)
        {
            throw new NotImplementedException();
        }

        public override object Divide(object numerator, object denumerator)
        {
            throw new NotImplementedException();
        }

        public override object Minus(object term1, object term2)
        {
            throw new NotImplementedException();
        }

        public override object Multiply(object factor1, object factor2)
        {
            throw new NotImplementedException();
        }

        public override void AddItemsToQueryHistory(object number, char arithmetic)
        {
            QueryHistory.Add(number);
            QueryHistory.Add(arithmetic);
        }

        protected override object SignCheck(char sign, int signIndex)
        {
            throw new NotImplementedException();
        }

        public override object Execute()
        {
            throw new NotImplementedException();
        }

        public override void RemoveAll()
        {
            QueryHistory.Clear();
        }
    }
}
