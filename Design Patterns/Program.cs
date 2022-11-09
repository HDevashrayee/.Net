// See https://aka.ms/new-console-template for more information
using Design_Patterns.Creational_Patterns.FactoryMethod.Structural;
using Design_Patterns.Creational_Patterns.FactoryMethod.RealWorld;
using Design_Patterns.Behavioral_Patterns.Observer.Structural;
using Design_Patterns.Behavioral_Patterns.Observer.RealWorld;
using Design_Patterns.Behavioral_Patterns.State.Structural;
using Design_Patterns.Behavioral_Patterns.State.RealWorld;
using Design_Patterns.Behavioral_Patterns.Strategy.Structural;
using Design_Patterns.Behavioral_Patterns.Strategy.RealWorld;

namespace Design_Patterns.Program
{
    public class Program
    {
        public static void Main()
        {
            Console.WriteLine("Please type number to execute the menu:\n\n");
            Console.WriteLine("1. Factory Method\n");
            Console.WriteLine("2. Observer\n");
            Console.WriteLine("3. State\n");
            Console.WriteLine("4. Strategy\n");
            short number = Convert.ToInt16(Console.ReadLine());
            string message = string.Empty;
            switch (number)
            {
                case 1:
                    #region FactoryMethod
                    Console.WriteLine("Structural Example...\n");
                    Creator[] creators = new Creator[2];
                    creators[0] = new ConcreteCreatorA();
                    creators[1] = new ConcreteCreatorB();

                    foreach (Creator creator in creators)
                    {
                        Product product = creator.FactoryMethod();
                        Console.WriteLine("Created {0}", product.GetType().Name);
                    }
                    Console.WriteLine("\nReal world Example...\n");
                    // Note: constructors call Factory Method

                    Document[] documents= new Document[2];
                    documents[0] = new Resume();
                    documents[1] = new Report();

                    //Display doccument pages.

                    foreach (Document document in documents)
                    {
                        Console.WriteLine("\n" + document.GetType().Name + "--");
                        foreach (Page page in document.Pages)
                        {
                            Console.WriteLine(" " + page.GetType().Name);
                        }
                    }
                    
                    Console.ReadKey();
                    #endregion
                    break;

                case 2:
                    #region Observer

                    // Configure Observer pattern

                    Console.WriteLine("\nStructural Example...\n");
                    ConcreteSubject subject = new ConcreteSubject();
                    subject.Attach(new ConcreteObserver(subject, "X"));
                    subject.Attach(new ConcreteObserver(subject, "Y"));
                    subject.Attach(new ConcreteObserver(subject, "Z"));

                    // Change subject and notify observers

                    subject.SubjectState = "ABC";
                    subject.Notify();

                    Console.WriteLine("\nReal world Example...\n");

                    // Create IBM stock and attach investors

                    IBM ibm = new IBM("IBM", 120.00);
                    ibm.Attach(new Investor("Sorros"));
                    ibm.Attach(new Investor("Berkshire"));

                    // Fluctuating prices will notify investors

                    ibm.Price = 121.1;
                    ibm.Price = 121.5;
                    ibm.Price = 121.6;
                    ibm.Price = 121.9;

                    Console.ReadKey();
                    #endregion
                    break;

                case 3:
                    #region State
                    Console.WriteLine("Structural Example...\n");
                    // Setup context in a state
                    Context context = new Context(new ConcreteStateA());

                    context.Request();
                    context.Request();
                    context.Request();
                    context.Request();
                    Console.WriteLine("\nReal world Example...\n");

                    // Open a new account
                    Account account = new Account("Jim Jhonson");
                    // Apply financial transaction

                    account.Deposit(500.0);
                    account.Deposit(300.0);
                    account.Deposit(550.0);
                    account.PayInterest();
                    account.Withdraw(2000.0);
                    account.Withdraw(1100.0);

                    Console.ReadKey();
                    #endregion
                    break;

                case 4:
                    #region Strategy
                    Console.WriteLine("Structural Example...\n");
                    ContextStrategy contextStrategy;

                    contextStrategy = new ContextStrategy(new ConcreteStrategyA());
                    contextStrategy.ContextInterface();

                    contextStrategy = new ContextStrategy(new ConcreteStrategyB());
                    contextStrategy.ContextInterface();

                    contextStrategy = new ContextStrategy(new ConcreteStrategyC());
                    contextStrategy.ContextInterface();

                    Console.WriteLine("RealWorld Example...\n");

                    SortedList Records=new SortedList();
                    Records.Add("A");
                    Records.Add("B");
                    Records.Add("C");
                    Records.Add("D");
                    Records.Add("E");

                    Records.SetSortStrategy(new QuickSort());
                    Records.Sort();

                    Records.SetSortStrategy(new ShellSort());
                    Records.Sort();

                    Records.SetSortStrategy(new MergeSort());
                    Records.Sort();
                    Console.ReadKey();
                    #endregion
                    break;
                default: 
                    message= "Please select an option";
                    break;
            }

        }
    }

}
