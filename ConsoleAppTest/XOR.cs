using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppTest
{
    internal class XOR
    {
        public static string strings_xor(string s, string t)
        {
            string res = "";

            for (int i = 0; i < s.Length; i++)
            {
                if (s.Substring(i,1) != t.Substring(i, 1))
                {
                    res = res + 1;
                }
                else
                    res = res + 0;
            }            
            return res;
        }
    }
}
