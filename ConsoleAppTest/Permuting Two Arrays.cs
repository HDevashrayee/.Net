using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppTest
{
    internal class Permuting_Two_Arrays
    {
        public static string GetPermutingArrays(int k, List<int> A, List<int> B)
        {
            string result = "YES";
            int value = 0;
            int indexA = 0;
            int indexB = 0;
            while (A.Count > 0 && result == "YES")
            {
                result = "";
                value = 0;
                for (int i = 0; i < A.Count; i++)
                {
                    for (int j = 0; j < B.Count; j++)
                    {                        
                        if (A[i] + B[j] >= k)
                        {
                            if (value == 0 || value > A[i] + B[j])
                            {
                                value = A[i] + B[j];
                                indexB = j;
                                result = "YES";
                            }
                        }
                    }
                    if (result == "YES")
                    {
                        indexA = i;
                        break;
                    }
                    if (i == A.Count - 1)
                        result = "NO";
                    if (result == "NO")
                    {
                        break;
                    }
                }
                if (result == "YES")
                {
                    A.RemoveAt(indexA);
                    B.RemoveAt(indexB);                   
                }
            }
            return result;
        }
    }
}
