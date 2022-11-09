using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.Behavioral_Patterns.Observer
{
    public class Observer
    {
        /*
         The Observer design pattern defines a one-to-many dependency between objects so that when one object changes state, 
         all its dependents are notified and updated automatically.
         Frequency of use:high
         */

        /*
         Participants

         The classes and objects participating in this pattern include:
         
         Subject  (Stock)
            knows its observers. Any number of Observer objects may observe a subject
            provides an interface for attaching and detaching Observer objects.

         ConcreteSubject  (IBM)
            stores state of interest to ConcreteObserver
            sends a notification to its observers when its state changes

         Observer  (IInvestor)
            defines an updating interface for objects that should be notified of changes in a subject.

         ConcreteObserver  (Investor)
            maintains a reference to a ConcreteSubject object
            stores state that should stay consistent with the subject's
            implements the Observer updating interface to keep its state consistent with the subject's
         */
    }
}

namespace Design_Patterns.Behavioral_Patterns.Observer.Structural
{
    //This structural code demonstrates the Observer pattern in which registered objects are notified and updated with a state change.

    /// <summary>
    /// The 'Subject' abstract class
    /// </summary>
    /// 

    public abstract class Subject
    {
        private List<Observer> observers = new List<Observer>();

        public void Attach(Observer observer)
        {
            observers.Add(observer);
        }

        public void Detach(Observer observer)
        {
            observers.Remove(observer);
        }

        public void Notify()
        {
            foreach (Observer _observer in observers)
            {
                _observer.Update();
            }
        }
    }

    /// <summary>
    /// The 'ConcreteSubject' class
    /// </summary>
    /// 

    public class ConcreteSubject : Subject
    {
        private string subjectState;

        public string SubjectState 
        {
            get { return subjectState; } 
            set { subjectState = value; } 
        }
    }


    /// <summary>
    /// The 'Observer' abstract class
    /// </summary>

    public abstract class Observer
    {
        public abstract void Update();
    }

    /// <summary>
    /// The 'ConcreteObserver' class
    /// </summary>
    /// 

    public class ConcreteObserver : Observer
    {
        private string name;
        private string observerState;
        private ConcreteSubject subject;

        public ConcreteObserver(ConcreteSubject subject, string name)
        {
            this.subject = subject;
            this.name = name;
        }

        public override void Update()
        {
            observerState = subject.SubjectState;
            Console.WriteLine("Observer {0}'s new state is {1}", name, observerState);
        }

        public ConcreteSubject Subject
        {
            get { return subject; }
            set { subject = value; }
        }
    }

}

namespace Design_Patterns.Behavioral_Patterns.Observer.RealWorld
{
    /// <summary>
    /// The 'Subject' abstract class
    /// </summary>
    /// 

    public abstract class Stock
    {
        private string symbol;
        private double price;
        private List<IInvestor> investors = new List<IInvestor>();

        // Constructor

        public Stock(string symbol, double price)
        {
            this.symbol = symbol;
            this.price = price;
        }     
        
        public void Attach(IInvestor investor)
        {
            investors.Add(investor);
        }

        public void Detach(IInvestor investor)
        {
            investors.Remove(investor);
        }

        public void Notify()
        {
            foreach (IInvestor investor in investors)
            {
                investor.Update(this);
            }

            Console.WriteLine("");
        }

        // Gets or sets the price

        public double Price
        {
            get { return price; }
            set
            {
                if (price!=value)
                {
                    price = value;
                    Notify();
                }
            }
        }

        // Gets the Symbol

        public string Symbol
        {
            get { return symbol; }
        }
    }

    /// <summary>
    /// The 'ConcreteSubject' class
    /// </summary>
    /// 

    public class IBM : Stock
    {
        // Constructor

        public IBM(string symbol, double price)
            : base(symbol, price)
        {

        }
    }

    /// <summary>
    /// The 'Observer' interface
    /// </summary>
    /// 

    public interface IInvestor
    {
        public void Update(Stock stock);
    }


    /// <summary>
    /// The 'ConcreteObserver' class
    /// </summary>
    /// 

    public class Investor : IInvestor
    {
        private string name;
        private Stock stock;

        public Investor(string name)
        {
            this.name = name;
        }

        public void Update(Stock stock)
        {
            Console.WriteLine("Notified {0} of {1}'s" +
                "change to {2:C}", name, stock.Symbol, stock.Price); ;
        }

        public Stock Stock
        {
            get { return stock; }
            set { stock = value; }
        }
    }
}

