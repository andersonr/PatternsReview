using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Observer
{
    class ConcreteObserverA : IObserver
    {
        public void Update(ISubject subject)
        {
            if ((subject as Subject)?.State < 3)
            {
                Console.WriteLine("ConcreteObserverA: Reacted to the event >> {0}", true);
            }
        }
    }

    class ConcreteObserverB : IObserver
    {
        public void Update(ISubject subject)
        {
            if ((subject as Subject)?.State == 0 || (subject as Subject)?.State >= 2)
            {
                Console.WriteLine("ConcreteObserverB: Reacted to the event >> {0}", true);
            }
        }
    }

    internal class Index
    {
        public void Main()
        {
            var subject = new Subject();
            var observerA = new ConcreteObserverA();
            subject.Attach(observerA);

            var observerB = new ConcreteObserverB();
            subject.Attach(observerB);

            subject.SomeBusinessLogic();
            subject.SomeBusinessLogic();

            subject.Detach(observerB);

            subject.SomeBusinessLogic();
            subject.SomeBusinessLogic();
            subject.SomeBusinessLogic();
            subject.SomeBusinessLogic();
            subject.SomeBusinessLogic();

        }
    }
}
