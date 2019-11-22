using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace v47___Solid
{
    class Program
    {
        static readonly ICalculation<double>[] Arithmatics = { new Add(), new Subtract() };

        static int i = 0;

        static void Main(string[] args)
        {
            string input = "";
            do
            {
                Console.WriteLine("Write an expression");
                input = Console.ReadLine();
                string[] expression = input.Split(' ');


                for (i = 0; i < Arithmatics.Length && expression.Length > 1; i++)
                {

                }
            } while (!(input.ToLower().Contains("exit")));
        }
    }
}
