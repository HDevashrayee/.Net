using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppTest
{
    internal static class Sparse_Arrays
    {
        /*
         There is a collection of input strings and a collection of query strings. 
         For each query string, determine how many times it occurs in the list of input strings. Return an array of the results.

         Function Description
         
         Complete the function matchingStrings in the editor below. 
         The function must return an array of integers representing the frequency of occurrence of each query string in strings.
         
         matchingStrings has the following parameters:
         
         string strings[n] - an array of strings to search
         string queries[q] - an array of query strings
         Returns
         
         int[q]: an array of results for each query
         Input Format
         
         The first line contains and integer , the size of .
         Each of the next  lines contains a string .
         The next line contains , the size of .
         Each of the next  lines contains a string .
         
         */

        internal static List<int> GetSparseArrays(List<string> strings, List<string> queries)
        {
            List<int> result = new List<int>();
            foreach (var item in queries)
            {
                result.Add(strings.FindAll(d => d.Equals(item)).Count);
            }
            return result;
        }
    }
}
