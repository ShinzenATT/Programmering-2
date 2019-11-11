using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace v45
{
    public class Suv : Vehicle
    {
        public Suv()
        {
            Brand = "Toyota";
            Model = "Hilux";
            Name = Brand + " " + Model;
        }
        public override string Move()
        {
            return string.Format("As you press the pedal {0} starts to drive and armors you somewhat from the enviorement. Who cares about the enviorement? {0} doesn't.", Name);
        }

        public override string Start()
        {
            return string.Format("You put in the key in the keyhole inside of {0} and turn it. You hear the motor making a sound and {0} starts shaking.",Name);
        }

        public override string Style()
        {
            return string.Format("During the drive, {0} drifted for 10 whole seconds. +10 cool points.", Name);
        }

        public override string TurnOff()
        {
            return string.Format("As {0} stops you turn the key. The sound and shaking stop. {0} will wait for you like a good boy.", Name);
        }
    }
}
