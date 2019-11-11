using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace v46___Interface
{
    interface IHuman
    {
        string interest { get; }
        string name { get;}
        bool willToLive { get; set; }

        string InterestAction();

        string Introduction();

        string Philosophy();

        string WakeUp();

        string BedTime();

        string Work();

    }
}
