using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppTest
{
    internal class Pangrams
    {
        public static string GetPangrams(string statment)
        {
            string result = "pangram";
            string[] alphabet = "a b c d e f g h i j k l m n o p q r s t u v w x y z".Split(" ".ToCharArray());
            if (!string.IsNullOrEmpty(statment) && statment.Length <= 1000)
            {
                foreach(string s in alphabet)
                {
                    if (!statment.ToLower().Contains(s))
                    {
                        return "not pangram";
                    }
                }                
            }
            else
                return "not pangram";
            return result;
        }
    }
}
