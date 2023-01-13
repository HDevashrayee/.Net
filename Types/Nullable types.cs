using System;
using System.Collections.Generic;
using System.Text;

namespace Types
{
    internal class Nullable_types
    {
        //Variables of any type may be declared as non-nullable or nullable. A nullable variable can hold an additional null value, indicating no value. Nullable Value types (structs or enums) are represented by System.Nullable<T>. Non-nullable and Nullable Reference types are both represented by the underlying reference type. The distinction is represented by metadata read by the compiler and some libraries. The compiler provides warnings when nullable references are dereferenced without first checking their value against null. The compiler also provides warnings when non-nullable references are assigned a value that may be null. The following example declares a nullable int, initializing it to null. Then, it sets the value to 5. It demonstrates the same concept with a nullable string. For more information, see nullable value types and nullable reference types.
        private void Main()
        {
            int? optionalInt = default;
            optionalInt = 5;
            string? optionalText = default;
            optionalText = "Hello World.";
        }
    }
}
