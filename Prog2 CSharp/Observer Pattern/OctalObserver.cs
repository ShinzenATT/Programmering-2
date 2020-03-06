using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer_Pattern
{
    public class OctalObserver : Observer
    {
        public OctalObserver(Subject subject)
        {
            this.Subject = subject;
            this.Subject.Attach(this);
        }

        public override void Update()
        {
            Console.WriteLine( "Octal value: " + Convert.ToString(Subject.State, 8));
        }
    }
}
