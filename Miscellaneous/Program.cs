using System;

namespace Miscellaneous
{
    internal class Program
    {
        static void Main(string[] args)
        {
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
            PersonClass personClass = new PersonClass("Leo", 0);
            Console.WriteLine("Name = {0} \n Age = {1}", personClass.Name, personClass.Age);

            PersonClass personClass1 = personClass;
            personClass1.Name = "Spencer";
            personClass.Age = 2;

            // p1 values will also change because p2 is a refrencing p1 class.
            Console.WriteLine("Name = {0} \n Age = {1}", personClass.Name, personClass.Age);

            //struct

            PersonStruct personStruct = new PersonStruct("Max",5);
            Console.WriteLine("Name = {0} \n Age = {1}", personStruct.Name, personStruct.Age);

            PersonStruct personStruct1 = personStruct;
            personStruct1.Name = "Joe";
            personStruct1.Age = 3;
            // p1 values remain unchanged because p2 is  copy.
            Console.WriteLine("Name = {0} \n Age = {1}", personStruct.Name, personStruct.Age);


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

          

        }
    }
}
