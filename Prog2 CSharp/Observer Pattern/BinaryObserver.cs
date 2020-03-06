using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer_Pattern
{
    class BinaryObserver : Observer
    {
        public BinaryObserver(Subject subject)
        {
            this.Subject = subject;
            this.Subject.Attach(this);
        }

        public override void Update()
        {
            Console.WriteLine("Binary String: " + ToBinary( (Byte) Subject.State ) ) ;
        }

        public static String ToBinary(Byte data)
        {
            return string.Join(" ", Convert.ToString(data, 2).PadLeft(8, '0'));
        }
    }
}
