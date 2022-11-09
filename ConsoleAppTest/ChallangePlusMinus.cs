using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppTest
{
    public class ChallangePlusMinus
    {
        /*
         Given an array of integers, calculate the ratios of its elements that are positive, 
         negative, and zero. Print the decimal value of each fraction on a new line with  places after the decimal.
         */
        internal static void PlusMinus(List<int> arr)
        {
            decimal P = 0;
            decimal Z = 0;
            decimal N = 0;

            foreach (var value in arr)
            {
                if (value>0)
                {
                    P++;
                }
                else if (value <0)
                {
                    N++;
                }
                else
                {
                    Z++;
                }
            }

            Console.WriteLine((P / arr.Count).ToString("0.0000000") + "\n");
            Console.WriteLine((N / arr.Count).ToString("0.0000000") + "\n");
            Console.WriteLine((Z / arr.Count).ToString("0.0000000") + "\n");
        }
    }
}
