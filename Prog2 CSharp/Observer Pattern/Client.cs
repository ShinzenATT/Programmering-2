using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer_Pattern
{
    class Client
    {
        private static readonly Subject subject = new Subject();
        static void Main(string[] args)
        {
            Console.WriteLine("Program start");
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
            Console.WriteLine("");

            new BinaryObserver(subject);
            new OctalObserver(subject);
            new HexObserver(subject);

            StateChange(15);
            StateChange(10);

            Console.WriteLine("Program end");
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }

        private static void StateChange(int value)
        {
            Console.WriteLine("State change: " + value);
            subject.State = value;

            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
            Console.WriteLine("");
        }
    }
}
