using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;
using Aes_Example;

namespace ConsoleAppTest
{
    class Program
    {
        public static void Main(string[] args)
        {

            //List<int> arr = new List<int> { 1, 2, 3, 0, -4, -1, -2, 0 };
            //ChallangePlusMinus.PlusMinus(arr);

            //arr = new List<int> { 1, 2, 3, 4, 5 };
            //ChallangeMinMaxSum.miniMaxSum(arr);

            //Time_Conversion.GetTimeConversion("12:05:45AM");

            //List<string> strings = new List<string> { "abc", "xyz", "pq", "rz", "abc", "pq", "abc" };
            //List<string> quereis = new List<string> { "abc", "xyz", "pq", "rz", "az" };
            //List<int> result = Sparse_Arrays.GetSparseArrays(strings, quereis);
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}

            //List<int> array = new List<int> { 1, 2, 3, 4, 3, 2, 1 };
            //int a = LonelyInteger.GetLonelyInteger(array);
            //Console.WriteLine(a);

            long f = Flipping_bits.GetFlippedBits(9);

            //List<int> row1 = new List<int> { 1, 2, 3 };
            //List<int> row2 = new List<int> { 4, 5, 6 };
            //List<int> row3 = new List<int> { 9, 8, 9 };
            //List<List<int>> ints = new List<List<int>>();
            //ints.Add(row1);
            //ints.Add(row2);
            //ints.Add(row3);

            //int resultint = Diagonal_Difference.GetDiagonalDifference(ints);
            //List<int> arrayint = new List<int>();
            //Counting_Sort.GetCountingSort(arrayint);

            //string resultPang = Pangrams.GetPangrams("We promptly judged antique ivory buckles for the next prize");

            //int k = 9;
            //List<int> A = new List<int>() { 3, 6, 8, 5, 9, 9, 4, 8, 4, 7 };
            //List<int> B = new List<int>() { 5, 1, 0, 1, 6, 4, 1, 7, 4, 3 };

            //string r1 = Permuting_Two_Arrays.GetPermutingArrays(k, A, B);
            //Console.WriteLine(r1);
            ////List<int> r2 = new List<int>() { 2, 2, 2, 1, 3, 2, 2, 3, 3, 1, 4, 1, 3, 2, 2, 1, 2, 2, 4, 2, 2, 3, 5, 3, 4, 3, 2, 1, 4, 5, 4 };
            //List<int> r2 = new List<int>() { 2, 5, 1, 3, 4, 4, 3, 5, 1, 1, 2, 1, 4, 1, 3, 3, 4, 2, 1 };
            //Subarray_Division_1.GetSubarrayDivision(r2, 18, 7);

            //Console.WriteLine("Please enter strings");
            //string s = Console.ReadLine();
            //string t = Console.ReadLine();

            //XOR.strings_xor(s, t);

            //EncryptionDecryption encryptionDecryption = new EncryptionDecryption();
            //encryptionDecryption.Encrypt();

            AesExample.MainStream();
        }

    }
}

