using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer_Pattern
{
    public class Subject
    {
        private List<Observer> observers = new List<Observer>();

        private int _state;
        public int State
        {
            get { return _state; }

            set
            {
                _state = value;
                NotifyAllObservers();
            }
        }

        public void Attach(Observer observer)
        {
            observers.Add(observer);
        }

        public void NotifyAllObservers()
        {
            foreach(Observer observer in observers)
            {
                observer.Update();
            }
        }

    }
}
