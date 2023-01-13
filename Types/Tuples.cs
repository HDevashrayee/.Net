
using System;
using System.Collections.Generic;
using System.Text;

namespace Types
{
    internal class Tuples
    {
        //C# supports tuples, which provides concise syntax to group multiple data elements in a lightweight data structure. You instantiate a tuple by declaring the types and names of the members between ( and ), as shown in the following example:
        private void main()
        {
            (double Sum, int Count) t2 = (4.5, 3);
            Console.WriteLine($"Sum of {t2.Count} elements is {t2.Sum}.");
            //Output:
            //Sum of 3 elements is 4.5.
        }
    }
}
