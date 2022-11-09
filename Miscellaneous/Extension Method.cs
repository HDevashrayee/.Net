using System;
using System.Collections.Generic;
using System.Text;

namespace Miscellaneous
{
    internal static class Extension_Method
    {
        internal static int WordCount(this string str)
        {
            return str.Split(new char[] { ' ', '.', '?' },
                StringSplitOptions.RemoveEmptyEntries).Length;
        }
    }
}
