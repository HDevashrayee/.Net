using System;

namespace Encapsulation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            
        }
    }

    #region Protected internal


    //Assembly1
    public class BaseClass
    {
        protected internal int myValue = 0;
    }

    class TestAccess
    {
        void Access()
        {
            var baseObject = new BaseClass();
            baseObject.myValue = 5;
        }
    }
    /*
     A protected internal member of a base class is accessible from any type within its containing assembly. 
    It is also accessible in a derived class located in another assembly only if the access occurs through a variable of the derived class type. 
     */
    //Assembly2
    class DerivedClass : BaseClass
    {
        static void DMethod()
        {
            var baseObject = new BaseClass();
            var derivedObject = new DerivedClass();
            derivedObject.myValue = 5;
        }
    }
    #endregion
}
