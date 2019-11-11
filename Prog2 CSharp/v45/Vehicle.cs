using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace v45
{
    public abstract class Vehicle
    {
        
        protected string Brand { get; set; }
        protected string Model { get; set; }
        protected string Name { get; set; }

        public abstract string Start();

        public abstract string Move();

        public abstract string Style();

        public abstract string TurnOff();

        public string RoleCall()
        {
            return Name + " to your service.";
        }
    }
}
