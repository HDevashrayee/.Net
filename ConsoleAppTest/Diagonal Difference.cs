using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppTest
{
    internal class Diagonal_Difference
    {
        public static int GetDiagonalDifference(List<List<int>> matrix)
        {
            int value = 0;
            int dA = 0;
            int dB = 0;

            for (int i = 0; i < matrix.Count; i++)
            {
                dA = dA + matrix[i][i];
            }

            for (int i = 0; i < matrix.Count; i++)
            {
                dB = dB + matrix[i][matrix.Count - 1 - i];
            }
            value = Math.Abs(dA - dB);
            return value;
        }
    }
}
