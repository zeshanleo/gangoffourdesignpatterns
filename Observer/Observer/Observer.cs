using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{

    public abstract class Subject
    {
        public List<Observer> observers = new List<Observer>();
        public string SubjectState { get; set; }

        public abstract void Attach(Observer observer);
        public abstract void Remove(Observer observer);
        public abstract void Notify();
    }

    public class ConcreteSubject : Subject
    {
        public override void Attach(Observer observer)
        {
            observers.Add(observer);
        }

        public override void Remove(Observer observer)
        {
            observers.Remove(observer);
        }

        public override void Notify()
        {
            foreach (var observer in observers)
            {
                observer.Update();
            }
        }
    }


    public abstract class Observer
    {
        public abstract void Update();

    }

    public class ConcreteObserver : Observer
    {
        private Subject _subject;
        private string _name;
        public ConcreteObserver(Subject subject, string name)
        {
            this._subject = subject;
            this._name = name;
        }

        public override void Update()
        {
            Console.WriteLine("Observe {0}'s new state is {1}", _name, _subject.SubjectState);
        }
    }
}
