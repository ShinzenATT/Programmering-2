using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace v46___Interface
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Time for a story. Click any key to continue");
            Console.ReadKey();
            Console.WriteLine();

            IHuman[] h = { new Humans.Bob(), new Humans.Bob() };

            foreach (IHuman human in h)
            {
                string[] story = { human.Introduction(), human.WakeUp(), human.Work(), human.Philosophy(), human.InterestAction(), human.BedTime() };
                foreach (string piece in story)
                {
                    Console.WriteLine(piece);
                    Console.ReadKey();
                    Console.WriteLine();
                }
                Console.WriteLine();
            }
        }
    }
}
