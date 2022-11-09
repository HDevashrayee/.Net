using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace ConsoleAppTest
{
    internal static class LonelyInteger
    {
        /*
        Given an array of integers, where all elements but one occur twice, 
        find the unique element.

        Example

        a = [1,2,3,4,3,2,1]
        The unique element is 4.
         */

        internal static int GetLonelyInteger(List<int> array)
        {
            List<int> list = new List<int>();
            for (int i = 0; i < array.Count; i++)
            {
                if (list.Contains(array[i]))
                {
                    list.Remove(array[i]);
                }
                else
                {
                    list.Add(array[i]);
                }
            }
            return list.FirstOrDefault();
        }
    }
}
