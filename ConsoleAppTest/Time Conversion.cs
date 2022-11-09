using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppTest
{
    internal static class Time_Conversion
    {
        public static void GetTimeConversion(string time)
        {

            string[] array = time.Split(":");           
            
            if (time.Contains("AM") && array[0] == "12")
            {
                array[0] = "00";
            }            
            if(time.Contains("PM") && array[0] != "12")
            {
                array[0] = Convert.ToString(Convert.ToInt16("12") + Convert.ToInt16(array[0]));
            }
            array[2] = array[2].Replace("AM", "").Replace("PM", "");

            Console.WriteLine(string.Join(":", array));
        }
    }
}
