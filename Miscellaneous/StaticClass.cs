using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Miscellaneous
{
    public static class StaticClass
    {
        public static void StaticMethod(string a)
        {
            while(true)
            {
                Console.WriteLine(a);
            }
        }
    }
}
