using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace v46___Interface.Humans
{
    class Bob : IHuman
    {
        public string interest { get; } = "knitting";
        public string name { get; } = "Bob";
        public bool willToLive { get; set; } = true;



        public string BedTime()
        {
            return string.Format("{0} goes to bed. This day was a good day.", name);
        }

        public string InterestAction()
        {
            return string.Format("{0} decides to do some {1}. {0} is happy.", name, interest);
        }

        public string Introduction()
        {
            return string.Format("This is {0}. Be nice to {0}.", name);
        }

        public string Philosophy()
        {
            willToLive = false;
            return string.Format("{0} thinks about the universe. {0} realizes that his existence is meaningless and will be another statistic among the thousends of humans. {0} has lost the will to live.", name);
        }

        public string WakeUp()
        {
            return string.Format("{0} gets out of bed and stand in front of a window to appreciate nature. {0} is ready to start the day.", name);
        }

        public string Work()
        {
            return string.Format("{0} goes to work. It was a blast");
        }
    }
}
