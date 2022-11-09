namespace Dotnet.Delegates
{
    public delegate void DelegateObject(string instance);

    public class Delegates
    {
        /*
        A delegate is a type that represents references to methods with a particular parameter list and return type. 
        When you instantiate a delegate, you can associate its instance with any method with a compatible signature and return type. 
        You can invoke (or call) the method through the delegate instance.

        Delegates are used to pass methods as arguments to other methods. 
        Event handlers are nothing more than methods that are invoked through delegates. 
        You create a custom method, and a class such as a windows control can call your method when a certain event occurs.
         */

        // Define the delegate.
        //public delegate void DelegateObject(string instance);

        // Create a method for delegate.
        DelegateObject handlerDel1 = DelegateMethod;
        public static void DelegateMethod(string message)
        {
            Console.WriteLine(message);
        }

        // Call delegate method
        //public static void DelegateCall()
        //{
        //    // Instantiate the delegate.

        //    DelegateObject DelegateHandler = DelegateMethod;

        //    // Call the delegate.

        //    DelegateHandler("Hello Delegates");
        //}

        #region Use delegate type as a paramaeter
        public static void MethodWithCallback(int param1, int param2, DelegateObject callbackDelegate)
        {
            callbackDelegate("The sum of number is: " + (param1 + param2).ToString());
        }
        #endregion
    }

    public class Program
    {
        public static void Main()
        {
            DelegateObject handlerDel;
            
            handlerDel = Delegates.DelegateMethod;

            handlerDel("Hello Delegates");

            Delegates.MethodWithCallback(1, 2, handlerDel);
        }
    }
}