using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Miniraknare
{
    public class CalcExecution : Calc
    {
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

        public override void AddItemsToQueryHistory(object number, char arithmetic)
        {
            QueryHistory.Add(number);
            QueryHistory.Add(arithmetic);
        }

        public void AddItem(object number)
        {
            QueryHistory.Add(number);
        }

        protected override object SignCheck(char sign, int signIndex)
        {
            throw new NotImplementedException();
        }

        public override object Execute()
        {

            char[] letters = { '/', '*', '+', '-' };
            for (int l = 0; l < letters.Length; l++)
            {
                for (int i = 0; i < QueryHistory.Count(); i++)
                {
                    if (QueryHistory[i].GetType() == typeof(char) && QueryHistory[i].Equals(letters[l]))
                    {
                        switch (letters[l])
                        {
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
                        QueryHistory.RemoveAt(i + 1);
                    }
                }
            }
            return QueryHistory[0];
        }


        public override void RemoveAll()
        {
            QueryHistory.Clear();
        }
    }
}

