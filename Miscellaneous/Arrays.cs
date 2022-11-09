using System;
using System.Collections.Generic;
using System.Text;

namespace Miscellaneous
{
    internal class Arrays
    {
        // Declare a single-dimensional array of 5 integers.


        int[] uniqArray;

        int[] array = new int[5];

        int[] array2 = new int[] { 1, 5, 3 };

        string[] strings = new string[5];
        string[] strings2 = new string[] { "A", "B", "C" };

        // Declare a two dimensional array.
        int[,] multiDimenshionalArray = new int[2, 3];
        int[,] multiDimenshionalArray2 = { { 1, 2, 3 }, { 4, 5, 6 } };

        
        // Set the values of the first array in the jagged array structure.
        

        internal Array SingleDimensionalArray()
        {
            array = new int[5];
            array[0] = 1;
            return array;            
        }

        internal Array MultidimensionalArray()
        {
            int[,] mdArray = new int[3, 2] { { 1, 2 }, { 3, 4 }, { 5, 6 } };
            return mdArray;
        }

        internal Array JaggedArray()
        {
            // Declare a jagged array.
            int[][] jaggedArray = new int[3][];
            jaggedArray[0] = new int[5];
            jaggedArray[1] = new int[2];
            jaggedArray[1][0] = 6;
            jaggedArray[2] = new int[] { 1, 2, 3 };
            return jaggedArray;
        }

        internal List<Array> GetImplicitlyTypedArray()
        {
            /*
             an implicitly-typed array in which the type of the array instance is inferred from the elements specified in the array initializer.
             The following examples show how to create an implicitly-typed array:
             */

            List<Array> arrays = new List<Array>();
            var a = new[] { 1, 2, 3 };
            arrays.Add(a);
            var b = new[] { "A", null, "B" };
            arrays.Add(b);

            // Single-dimenstional jagged array
            var c = new[]
            {
                new[] { 1, 2, 3 },
                new[] { 1, 2, 3 }
            };
            arrays.Add(c);

            //jagged array of strings

            var d = new[]
            {
                new[]{"a", "b", "c"},
                new[]{"a","g","l"}
            };
            arrays.Add(d);

            return arrays;
        }
    }
}
