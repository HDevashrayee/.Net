using System;
using System.Collections.Generic;
using System.Linq;

namespace LINQ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LinqClass linqClass = new LinqClass();
            linqClass.GetLinq();
        }
    }

    internal class LinqClass
    {
        // The Three Parts of a LINQ Query:
        // 1. Data source.
        int[] scores = { 97, 92, 87, 60 };

        internal void GetLinq()
        {
            // 2. Query creation.
            // numQuery is an IEnumerable<int>
            IEnumerable<int> scoreQuery=
                from score in scores
                where score > 0
                select score;

            // 3. Query execution.
            foreach (int item in scoreQuery)
            {
                Console.WriteLine(item + " ");
            }
        } 


    }
}

