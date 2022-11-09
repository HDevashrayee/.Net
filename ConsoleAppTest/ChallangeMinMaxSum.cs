using System.Collections.Generic;
using System;

namespace ConsoleAppTest
{
    internal static class ChallangeMinMaxSum
    {
        /*
    * Complete the 'miniMaxSum' function below.
    *
    * The function accepts INTEGER_ARRAY arr as parameter.
    */

        public static void miniMaxSum(List<int> arr)
        {
            long maxSum = 0;
            long minSum = 0;
            for (int i = 0; i < arr.Count; i++)
            {
                long sum = 0;
                List<int> newArr = new List<int>(arr);
                newArr.RemoveAt(i);
                foreach (var value in newArr)
                {
                    sum = sum + value;
                }
                if (minSum == 0 & maxSum ==0)
                {
                    maxSum = minSum = sum;
                }                
                if (sum > maxSum)
                {
                    maxSum = sum;
                }
                if (sum < minSum)
                {
                    minSum = sum;
                }
            }

            Console.WriteLine(minSum + " " + maxSum);
        }

    }
}