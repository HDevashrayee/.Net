﻿using Microsoft.VisualBasic;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace Miscellaneous
{
    internal class Program
    {
        static void Main(string[] args)
        {
            NewArray.GetArray();
            NewArray newArray = new NewArray();
            int a;
            int b= 0;
            newArray.GetValue(out a);
            newArray.GetValue1(ref b);

            Compare.compareString();
            Compare.compareObject(1,1);

            #region ExtensionMethod
            Console.WriteLine("Extension Method!\n");
            string str = "Hello Extension Methods";
            int i = str.WordCount();
            Console.WriteLine("'"+str+"'" + " string count: " + i);
            #endregion

            #region Classes and Objects
            var p1 = new Point(0, 0);
            var p2 = new Point(10, 20);
            Console.WriteLine("P1 : {0} \n P2 : {1} ", p1, p2);
            #endregion

            #region Class Vs Struct
           
            Struct_Instances_vs_Class_Instances.Run();

            #endregion

            #region Arrays
            Arrays arrays = new Arrays();
            int[] array = (int[])arrays.SingleDimensionalArray();
            Console.WriteLine("\n single-dimensional array \n");
            for (int j = 0; j < array.Length; j++)
            {
                Console.WriteLine(array[j]);
            }
            Console.WriteLine("\n multi-dimensional array \n");

            int[,] mdArray = (int[,])arrays.MultidimensionalArray();
            foreach (var item in mdArray)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("\n Jagged array \n");

            int[][] jArray = (int[][])arrays.JaggedArray();
            for (int k = 0; k < jArray.Length; k++)
            {
                for (int l = 0; l < jArray[k].Length; l++)
                {
                    Console.WriteLine(jArray[k][l]);
                }
            }
            #endregion

            //#region Tree
            //Tree<Myclass> tree = new Tree<Myclass>();
            //Action<Myclass> action = x => Console.WriteLine("{0} : {1}", x.Name, x.Number);

            //Binary_Tree.DoTree(tree, action);

            //#endregion
            #region Params
            Console.WriteLine("************ Parmas ****************");
            Params.Run();
            #endregion


        }
    }

    /// <summary>
    /// Diffrence between Equals() and ==
    /// Equals methodd compares contents while == compares refrence identity.
    /// </summary>
    class Compare
    {
        public delegate void resultcallback(int re);
        public static void compareObject(int a, int b)
        {
            if (a.Equals(b))
            {

            }
            if (a==b)
            {

            }

        }

        public static void compareString()
        {
            string a = "test";
            string b = "test1".Substring(0,4);
            object c = b;

            if (a.Equals(c))
            {

            }
            if (a==c)
            {

            }
            if (b==c)
            {

            }
        }
    }

    sealed class user { }
    public sealed class user1 { }

    /// <summary>
    /// Access last arrays
    /// </summary>
    class  NewArray
    {
        int a;
        int b = 1;
        public static string[] array = { "a", "b", "c","d","e" };


        public static async void GetArray()
        {
            foreach (var item in array)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine(array[^2]);
        }

        public async Task<int> calculate()
        {
            return 1;
        }

        public void GetValue(out int a)
        {
            a = 4;
        }

        public void GetValue1(ref int b)
        {
        b = 1;
        }

    }

}
