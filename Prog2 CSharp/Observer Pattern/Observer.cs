using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer_Pattern
{
    public abstract class Observer
    {
        protected Subject Subject;
        
        public abstract void Update();
    }
}
