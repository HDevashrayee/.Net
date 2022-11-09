using System;
using System.Collections.Generic;
using System.Collections;
namespace Generic
{
    /*
     Generics introduces the concept of type parameters to .NET, 
    which make it possible to design classes and methods that defer 
    the specification of one or more types until the class or method is declared and instantiated by client code.
    For example, by using a generic type parameter T, you can write a single class that other client code can use 
    without incurring the cost or risk of runtime casts or boxing operations

    Generic classes and methods combine reusability, type safety, and efficiency in a way that their non-generic counterparts cannot. 
    Generics are most frequently used with collections and the methods that operate on them. 
    The System.Collections.Generic namespace contains several generic-based collection classes. 
    The non-generic collections, such as ArrayList are not recommended and are maintained for compatibility purposes.
     */
    internal class Program
    {
        private class ExampleClass { }
        static void Main(string[] args)
        {
            #region Example1
            GenericList<int> genericList = new GenericList<int>();
            genericList.Add(1);

            GenericList<string> genericList1 = new GenericList<string>();
            genericList1.Add("string");
            Console.WriteLine("Generic!");

            GenericList<ExampleClass> genericList2 = new GenericList<ExampleClass>();
            genericList2.Add(new ExampleClass());

            Generic<string> generic = new Generic<string>();
            generic.Value = "A String";

            Console.WriteLine(generic.Value);
            Console.WriteLine(generic.Value.GetType());
            #endregion

            #region Covariance
            /*
            Enables you to use a more derived type than originally specified.
            You can assign an instance of IEnumerable<Derived> to a variable of type IEnumerable<Base>.
             */

            IEnumerable<Derived> deriveds = new List<Derived>();
            IEnumerable<Base> bases = deriveds;
            #endregion

            #region Contravariance
            /*
             Enables you to use a more generic (less derived) type than originally specified.
            You can assign an instance of Action<Base> to a variable of type Action<Derived>.
             */
            Action<Base> actionBase = (target) => { Console.WriteLine(target.GetType().Name); };
            Action<Derived> actionDerived = actionBase;
            actionDerived(new Derived());

            Action<Derived1> actionDerived1 = actionBase; ;
            actionDerived1(new Derived1());
            #endregion

            #region Linked List
            LinkedLists.GetLinkedList();
            #endregion

            #region Stack
            Stack.GetStack();
            #endregion

            #region Queue
            QueueClass.GetQueue();
            #endregion

            #region List
            List<Part> parts = new List<Part>();
            parts.Add(new Part() { PartId = 1, PartName = "A" });
            parts.Add(new Part() { PartId = 2, PartName = "B" });
            parts.Add(new Part() { PartId = 3, PartName = "C" });

            foreach (var item in parts)
            {
                Console.WriteLine(item);
            }


            parts.Contains(new Part { PartId = 3, PartName = "C" });

            // Insert a new item at position 2.
            Console.WriteLine("Insert a new item at position 2.");
            parts.Insert(2, new Part() { PartId=4, PartName = "D" });

            foreach (var item in parts)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("\nremove item");
            // This will remove part 1534 even though the PartName is different,
            // because the Equals method only checks PartId for equality.          

            parts.Remove(new Part() { PartId=3, PartName = "D" });

            foreach (var item in parts)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("\nRemove at");

            parts.RemoveAt(2);

            foreach (var item in parts)
            {
                Console.WriteLine(item);
            }
            #endregion

            #region SinglyLinkedList
            SinglyLinkedList singlyLinkedList = new SinglyLinkedList();
            singlyLinkedList.AddToLinkedList(0);
            singlyLinkedList.AddToLinkedList(1);
            singlyLinkedList.AddToLinkedList(2);
            singlyLinkedList.AddToLinkedList(3);
            singlyLinkedList.AddToLinkedList(4);
            singlyLinkedList.AddToLinkedList(5);

            singlyLinkedList.DisplayNextLinkedListItem(singlyLinkedList);
            
            #endregion

            #region DoublyLinkedList
            DoublyLinkedList doublyLinkedList = new DoublyLinkedList();
            doublyLinkedList.AddToLinkedList(0);
            doublyLinkedList.AddToLinkedList(1);
            doublyLinkedList.AddToLinkedList(2);
            doublyLinkedList.AddToLinkedList(3);
            doublyLinkedList.AddToLinkedList(4);
            doublyLinkedList.AddToLinkedList(5);

            doublyLinkedList.DisplayNextLinkedListItem(doublyLinkedList);

            doublyLinkedList.DisplayPrevLinkedListItem(doublyLinkedList);

            Console.ReadLine();

            #endregion
        }
    }
    /*
     Generics are classes, structures, interfaces, and methods that have placeholders (type parameters) 
    for one or more of the types that they store or use. 
    A generic collection class might use a type parameter as a placeholder for the type of objects that it stores; 
    the type parameters appear as the types of its fields and the parameter types of its methods. 
    A generic method might use its type parameter as the type of its return value or as the type of one of its formal parameters.
     */
    #region Example1
    public class GenericList<T>
    {
        public void Add(T input) { }
    }
    public class Generic<T>
    {
        public T Value { get; set; }
    }
    #endregion
    /*
    Covariance and contravariance are terms that refer to the ability to use a more derived type (more specific) 
    or a less derived type (less specific) than originally specified. 
    Generic type parameters support covariance and contravariance to provide greater flexibility in assigning and using generic types.
     */

    public class Base
    {
        public string Value { get; set; }       
    }
    public class Derived : Base
    {
        public Derived() { }
    }
    public class Derived1 : Base
    {
        public Derived1() { }
    }
}
