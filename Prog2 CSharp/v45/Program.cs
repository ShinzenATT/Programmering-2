using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace v45
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Time for a story. Click any key to continue");
            Console.ReadKey();
            Console.WriteLine();

            Vehicle[] v = { new Suv(), new Buv(), new MonsterTruck() };

            foreach(Vehicle vehicle in v)
            {
                string[] story = { vehicle.RoleCall(), vehicle.Start(), vehicle.Move(), vehicle.Style(), vehicle.TurnOff() };
                foreach(string piece in story)
                {
                    Console.WriteLine(piece);
                    Console.ReadKey();
                    Console.WriteLine();
                }
                Console.WriteLine();
                Console.WriteLine("~Fin~");
            }
        }
    }
}
