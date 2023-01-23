using System;
using System.Collections.Generic;
using System.Text;

namespace Types
{
    internal class Classes_and_Objects
    {
        public class Point
        {
            public int X { get; }
            public int Y { get; }

            public Point(int x, int y) => (X, Y) = (x, y);
        }
    }
}
