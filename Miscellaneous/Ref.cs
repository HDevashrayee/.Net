using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Miscellaneous
{
    public static class Ref
    {
        public static void Run()
        {
            int number = 1;
            Method(ref number);
            Console.WriteLine(number);
        }
        public static void Method(ref int refArgument)
        {
            refArgument = refArgument + 44;
        }        
    }
}
