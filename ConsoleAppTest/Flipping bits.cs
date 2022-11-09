using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleAppTest
{
    internal static class Flipping_bits
    {

        /*
         You will be given a list of 32 bit unsigned integers. Flip all the bits ( and ) and return the result as an unsigned integer.
         */
        internal static long GetFlippedBits(long n)
        {
            string bitstring = Convert.ToString(n, 2);
            string bitLength = "00000000000000000000000000000000";
            bitstring = bitLength.Substring(0, bitLength.Length - bitstring.Length) + bitstring;
            char[] chars = bitstring.ToCharArray();
            bitstring = String.Empty;

            for (int i = 0; i < chars.Length; i++)
            {
                if (chars[i].ToString() == "0")
                    chars[i] = '1';
                else
                    chars[i] = '0';

                bitstring = bitstring + chars[i];
            }

            n = Convert.ToInt64(bitstring,2);
            return n;
        }
    }
}
