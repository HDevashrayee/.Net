using System;

namespace Interface
{
    /*
      Interface members are public by default, and you can not explicitly specify accessibility modifiers, 
    such as public, protected, internal, private, protected internal, or private protected
     */

    public interface IEquatable<T>
    {
        bool Equals(T obj);
    }

    //private interface TestInterface
    //{
    //    void Foo();
    //}

    public class Car:IEquatable<Car>
    {
        public string? Make { get; set; }
        public string? Model { get; set; }
        public string? Year { get; set; }


        // Implementation of interface
        public bool Equals(Car? car)
        {
            return(this.Make, this.Model, this.Year)==
                (car?.Make, car?.Model, car?.Year);
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
