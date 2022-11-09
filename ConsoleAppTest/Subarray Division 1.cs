using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
namespace ConsoleAppTest
{
    internal class Subarray_Division_1
    {
        public static int GetSubarrayDivision(List<int> s, int d, int m)
        {
            List<int> list = new List<int>();
            List<int> list2 = new List<int>();
            int index1 = 0;
            int index2 = 0;
            bool isBreak = false;
          
            if (s.Count > 0 && s.Count <= 100 && d > 0 && d <= 31 && m > 0 && m <= 12)
            {
                foreach (var item in s)
                {
                    if (item <1 && item > 5)
                        return 0;
                }
                while (s.Count >= m)
                {
                    for (int i = 0; i < s.Count; i++)
                    {
                        index1 = i;

                        if (s.Count >= m)
                        {
                            list2 = new List<int>(s);
                            index2 = 0;
                            for (int j = 1; j <= list2.Count; j++)
                            {
                                index2++;
                                isBreak = false;
                                if (list2.GetRange(0, m).Sum() == d)
                                {
                                    list.Add(1);
                                    isBreak = true;
                                    break;
                                }
                                list2.RemoveAt(1);
                            }
                            if (isBreak)
                            {
                                if (s.Count - index2 >= m - 1)
                                {
                                    s.RemoveRange(index2, m - 1);
                                    s.RemoveAt(0);
                                }
                                else
                                    s.Clear();
                            }
                            else
                            {
                                if (s.Count >= m)
                                {
                                    s.RemoveAt(0);
                                }
                                else
                                    s.Clear();

                            }
                           
                        }
                        else
                        {
                            list2 = new List<int>(s);
                            index2 = 0;
                            for (int j = 1; j <= list2.Count; j++)
                            {
                                index2++;
                                isBreak = false;
                                if (list2.GetRange(0, 1).Sum() == d)
                                {
                                    list.Add(1);
                                    isBreak = true;
                                    break;
                                }
                                list2.RemoveAt(1);
                            }
                        }

                    }                                        
                }
            }
            return list.Count;
        }
    }
}
//if (s.Count > 0 && s.Count <= 100 && d > 0 && d <= 31 && m > 0 && m <= 12)
//{
//    if (s.Any(i => i > 5))
//        return 0;

//    for (int i = 0; i < s.Count; i++)
//    {
//        List<int> tempList = new List<int>(s);

//        while (tempList.Count - i > m)
//        {
//            if (tempList.GetRange(i, m).Sum() == d)
//            {
//                list.Add(1);
//                tempList.RemoveRange(i + 1, m);
//                break;
//            }
//            else
//            {
//                tempList.RemoveRange(i + 1, m);
//            }
//        }
//    }              
//}
