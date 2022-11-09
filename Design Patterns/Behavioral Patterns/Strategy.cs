using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.Behavioral_Patterns.Strategy
{
    public class Strategy
    {
        /*
         The Strategy design pattern defines a family of algorithms, encapsulate each one, and make them interchangeable. 
         This pattern lets the algorithm vary independently from clients that use it.
         Frequency of use: high
         */

        /* 
         Participants
         The classes and objects participating in this pattern include:
         
         Strategy  (SortStrategy)
         declares an interface common to all supported algorithms. 
         Context uses this interface to call the algorithm defined by a ConcreteStrategy.

         ConcreteStrategy  (QuickSort, ShellSort, MergeSort)
         implements the algorithm using the Strategy interface.

         Context  (SortedList)
         is configured with a ConcreteStrategy object
         maintains a reference to a Strategy object
         may define an interface that lets Strategy access its data.         
         */
    }
}

namespace Design_Patterns.Behavioral_Patterns.Strategy.Structural
{
    /*
     This structural code demonstrates the Strategy pattern which encapsulates functionality in the form of an object. 
     This allows clients to dynamically change algorithmic strategies.
     */

    /// <summary>
    /// The 'Strategy' abstract class
    /// </summary>
    /// 

    public abstract class Strategy
    {
        public abstract void AlgorithmInterface();
    }

    /// <summary>
    /// A 'ConcreteStrategy' class
    /// </summary>
 
    public class ConcreteStrategyA : Strategy
    {
        public override void AlgorithmInterface()
        {
            Console.WriteLine("Called ConcreteStrategyA.AlgorithmInterface()");
        }
    }

    public class ConcreteStrategyB : Strategy
    {
        public override void AlgorithmInterface()
        {
            Console.WriteLine("Called ConcreteStrategyB.AlgorithmInterface()");
        }
    }

    public class ConcreteStrategyC : Strategy
    {
        public override void AlgorithmInterface()
        {
            Console.WriteLine("Called ConcreteStrategyB.AlgorithmInterface()");
        }
    }
    /// <summary>
    /// The 'Context' class
    /// </summary>
    /// 

    public class ContextStrategy
    {
        Strategy strategy;

        public ContextStrategy(Strategy strategy)
        {
            this.strategy = strategy;
        }

        public void ContextInterface()
        {
            strategy.AlgorithmInterface();
        }
    }
}

namespace Design_Patterns.Behavioral_Patterns.Strategy.RealWorld
{
    /* 
     This real-world code ddemonstrates the Strategy pattern which encapsulates sorting algorithms in the form of sorting objects. 
     This allows clients to dynamically change sorting strategies including Quicksort, Shellsort, and Mergesort.
     */

    /// <summary>
    /// The 'Strategy' abstract class
    /// </summary>
    /// 

    public abstract class SortStrategy
    {
        public abstract void Sort(List<string> list);
    }

    /// <summary>
    /// A 'ConcreteStrategy' class
    /// </summary>
    /// 

    public class QuickSort :SortStrategy
    {
        public override void Sort(List<string> list)
        {
            Console.WriteLine("Quick Sort list");
        }
    }

    /// <summary>
    /// A 'ConcreteStrategy' class
    /// </summary>
    /// 

    public class ShellSort : SortStrategy
    {
        public override void Sort(List<string> list)
        {
            Console.WriteLine("Shell Sort list");
        }
    }

    /// <summary>
    /// A 'ConcreteStrategy' class
    /// </summary>
    /// 

    public class MergeSort : SortStrategy
    {
        public override void Sort(List<string> list)
        {
            Console.WriteLine("Merge Sort List");
        }
    }

    // <summary>
    /// The 'Context' class
    /// </summary>
    /// 

    public class SortedList
    {
        private List<string> list =new List<string>();
        private SortStrategy sortStrategy;

        public void SetSortStrategy(SortStrategy sortStrategy)
        {
            this.sortStrategy = sortStrategy;
        }

        public void Add(string name)
        {
            list.Add(name);
        }

        public void Sort()
        {
            sortStrategy.Sort(list);

            foreach (string name in list)
            {
                Console.WriteLine(" " + name);
            }
            Console.WriteLine();
        }
    }
}
