using System;
using System.Collections.Generic;
using System.Reflection.Metadata;
using System.Text;

namespace Types
{
    internal class Type_parameters
    {
        //Generic classes define type parameters.Type parameters are a list of type parameter names enclosed in angle brackets.Type parameters follow the class name. The type parameters can then be used in the body of the class declarations to define the members of the class. In the following example, the type parameters of Pair are TFirst and TSecond:
        public class Pair<TFirst, TSecond>
        {
            public TFirst First { get; }
            public TSecond Second { get; }

            public Pair(TFirst first, TSecond second) =>
                (First, Second) = (first, second);

            public void Method()
            {
                var pair = new Pair<int, string>(1, "Second");
                int i = pair.First;
                string s = pair.Second;
            }
        }
    }
}
