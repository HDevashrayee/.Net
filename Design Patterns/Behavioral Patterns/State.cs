using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.Behavioral_Patterns.State
{
    public class State
    {
        /*
         The State design pattern allows an object to alter its behavior when its internal state changes. 
         The object will appear to change its class.
         Frequency of use:medium
         */

        /*
        Participants
        The classes and objects participating in this pattern include:

        Context  (Account)
            defines the interface of interest to clients
            maintains an instance of a ConcreteState subclass that defines the current state.

        State  (State)
            defines an interface for encapsulating the behavior associated with a particular state of the Context.

        Concrete State  (RedState, SilverState, GoldState)
            each subclass implements a behavior associated with a state of Context 

         */
    }
}

namespace Design_Patterns.Behavioral_Patterns.State.Structural
{
    /*
     This structural code demonstrates the State pattern which allows an Account to behave differently depending on its balance. 
     The difference in behavior is delegated to State objects called RedState, SilverState and GoldState. 
     These states represent overdrawn accounts, starter accounts, and accounts in good standing.
     */

    /// <summary>
    /// The 'State' abstract class
    /// </summary>
    /// 
    public abstract class State
    {
        public abstract void Handle(Context context);
    }

    // <summary>
    /// A 'ConcreteState' class
    /// </summary>
    /// 

    public class ConcreteStateA:State
    {
        public override void Handle(Context context)
        {
            context.State = new ConcreteStateB();
        }
    }


    // <summary>
    /// A 'ConcreteState' class
    /// </summary>
    /// 
    
    public class ConcreteStateB:State
    {
        public override void Handle(Context context)
        {
            context.State = new ConcreteStateA();
        }
    }
    /// <summary>
    /// The 'Context' class
    /// </summary>
    public class Context
    {
        State state;

        // Constructor

        public Context(State _state)
        {
            state = _state;
        }

        public State State 
        {
            get { return state; }
            set 
            { 
                state = value;
                Console.WriteLine("State: "+ state.GetType().Name);
            }
        }

        public void Request()
        {
            state.Handle(this);
        }
    }

}

namespace Design_Patterns.Behavioral_Patterns.State.RealWorld
{
    /*
     This real-world code demonstrates the State pattern which allows an Account to behave differently depending on its balance. 
     The difference in behavior is delegated to State objects called RedState, SilverState and GoldState. 
     These states represent overdrawn accounts, starter accounts, and accounts in good standing.
     */

    /// <summary>
    /// The 'State' abstract class
    /// </summary>
    /// 

    public abstract class State
    {
        protected Account account;
        protected double balance;
        protected double interest;
        protected double lowerLimit;
        protected double upperLimit;

        public Account Account { get { return account; } set { account = value; } }
        public double Balance { get { return balance; } set { balance = value; } }

        public abstract void Withdraw(double amount);
        public abstract void Deposit(double amount);
        public abstract void PayInterest();
    }

    /// <summary>
    /// A 'ConcreteState' class
    /// <remarks>
    /// Red indicates that account is overdrawn 
    /// </remarks>
    /// </summary>
    /// 

    public class RedState : State
    {
        private double serviceFee;

        public RedState(State state)
        {
            this.balance = state.Balance;
            this.account = state.Account;
            Initialize();
        }

        private void Initialize()
        {
            interest = 0.0;
            lowerLimit = -100.0;
            upperLimit = 0.0;
            serviceFee = 15.00;
        }

        public override void Deposit(double amount)
        {
            balance += amount;
            StateChangeCheck();
        }

        public override void PayInterest()
        {
            balance += interest * balance;
        }

        public override void Withdraw(double amount)
        {
            amount = amount - serviceFee;
            Console.WriteLine("No funds availiable for withdrawl!");
        }

        private void StateChangeCheck()
        {
            if (balance > upperLimit)
            {
                account.State = new SilverState(this);
            }
        }
    }

    /// <summary>
    /// A 'ConcreteState' class
    /// <remarks>
    /// Silver indicates a non-interest bearing state
    /// </remarks>
    /// </summary>
    /// <summary>
    /// The 'Context' class
    /// </summary>
    /// 

    public class SilverState : State
    {
        public SilverState(State state):
            this(state.Balance, state.Account)
        {

        }

        public SilverState(double balance, Account account)
        {
            this.balance = balance;
            this.account = account;
            Initialize();
        }

        private void Initialize()
        {
            interest = 0.0;
            upperLimit = 1000.0;
            lowerLimit = 0.0;
        }

        public override void Deposit(double amount)
        {
            balance += amount;
            StateChangeCheck();
        }

        public override void PayInterest()
        {
            balance += interest * balance;
        }

        public override void Withdraw(double amount)
        {
            balance -= amount;
            StateChangeCheck();
        }

        private void StateChangeCheck()
        {
            if (balance<lowerLimit)
            {
                account.State=new RedState(this);
            }
            else if(balance>upperLimit)
            {
                account.State = new GoldState(this);
            }
        }
    }

    /// <summary>
    /// A 'ConcreteState' class
    /// <remarks>
    /// Gold indicates an interest bearing state
    /// </remarks>
    /// </summary>

    public class GoldState:State
    {
        // Overloaded constructors
        public GoldState(State state):
            this(state.Balance,state.Account)
        {

        }

        public GoldState(double balance, Account account)
        {
            this.balance = balance;
            this.account=account;
            Initialize();
        }

        private void Initialize()
        {
            interest = 0.05;
            lowerLimit = 1000.0;
            upperLimit = 1000000.0;
        }

        public override void Withdraw(double amount)
        {
            balance -= amount;
            StateChangeCheck();
        }

        public override void PayInterest()
        {
            balance += interest * balance;
            StateChangeCheck();
        }

        public override void Deposit(double amount)
        {
            balance += amount;
            StateChangeCheck();
        }

        private void StateChangeCheck()
        {
            if (balance<0.0)
            {
                account.State = new RedState(this);
            }
            else if(balance<lowerLimit)
            {
                account.State=new SilverState(this);
            }
        }
    }

    public class Account
    {
        private State state;
        private string owner;

        public Account(string owner)
        {
            this.owner = owner;
            this.state = new SilverState(0.0, this);
        }

        public double Balance
        {
            get { return state.Balance; }
        }

        public State State
        {
            get { return state; }
            set { state = value; }
        }

        public void Deposit(double amount)
        {
            state.Deposit(amount);
            Console.WriteLine("Deposited {0:C} --- ", amount);
            Console.WriteLine(" Balance = {0:C}", this.Balance);
            Console.WriteLine(" Status = {0}\n", this.State.GetType().Name);
            Console.WriteLine("");
        }

        public void Withdraw(double amount)
        {
            state.Withdraw(amount);
            Console.WriteLine("Withdrew {0:C} --- ", amount);
            Console.WriteLine(" Balance = {0:C}", this.Balance);
            Console.WriteLine(" Status  = {0}\n",
                this.State.GetType().Name);
        }

        public void PayInterest()
        {
            state.PayInterest();
            Console.WriteLine("Interest Paid --- ");
            Console.WriteLine(" Balance = {0:C}", this.Balance);
            Console.WriteLine(" Status  = {0}\n",
                this.State.GetType().Name);
        }
    }
}

