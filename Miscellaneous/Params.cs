using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Miscellaneous
{
    public static class Params
    {
        public static void Run()
        {
            Params1(1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13);
            Params2(1, 2, 3, 4, 5, 6, 7, 'a', 'b', 'c');
        }

        public static void Params1(params int[] list)
        {
            for (int i = 0; i < list.Length; i++)
            {
                Console.Write(list[i] + " ");
            }
            Console.WriteLine();
        }

        public static void Params2(params object[] lists)
        {
            for (int i = 0; i < lists.Length; i++)
            {
                Console.Write(lists[i] + " ");
            }
            Console.WriteLine();
        }
    }
}
