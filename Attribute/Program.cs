using System;
using System.Diagnostics;
namespace Attribute
{
    internal class Program
    {
        [Conditional("TRACE_ON")]
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            CustomAttributeClass.CustomAttribute();

            Trace.Msg("Now in Main..");
            Console.WriteLine("Done");
        }
    }

    #region Assembly level attributes 
    /*
     Assembly attributes are values that provide information about an assembly. They fall into the following categories:

     Assembly identity attributes
     Informational attributes
     Assembly manifest attributes
     */

    //[assembly: AssemblyVersion("1.0.0.0")]

    #endregion

    //Conditional attribute
    public class Trace
    {
        [Conditional("TRACE_ON")]
        public static void Msg(string msg)
        {
            Console.WriteLine(msg);
        }
    }
    

    //Creating Custom Attributes 

    [System.AttributeUsage(System.AttributeTargets.Class |
        System.AttributeTargets.Struct, AllowMultiple = true)]
    public class AuthorAttribute : System.Attribute
    {
        private string name; // postional parameter
        public double version; // any public property is named parameter

        public AuthorAttribute(string name)
        {
            this.name = name;
            this.version = 1.0;
        }
    }

    //use this new attribute as follows:

    [Author("A.Brt", version = 1.1)]
    [Author("S.lat", version =1.2)]
    internal class CustomAttributeClass
    {
        public static void CustomAttribute()
        {
            Console.WriteLine("Custom attribute");
        }
    }
}
