using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppTest
{
    internal class Sales_by_Match
    {
        public static int GetMatch(int n , List<int> ar)
        {
            List<int> items = new List<int>();
            int count = 0;
            if (n > 0 && n <= 100)
            {
                for (int i = 0; i < ar.Count; i++)
                {
                    if (ar[i] > 0 && ar[i] <= 100)
                    {
                        if (items.Contains(ar[i]))
                        {
                            items.Remove(ar[i]);
                            count++;
                        }
                        else
                            items.Add(ar[i]);
                    }
                }
            }
            return count;
        }
    }
}
