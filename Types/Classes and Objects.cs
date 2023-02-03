using System;
using System.Collections.Generic;
using System.Text;

namespace Types
{
    //Class
    public class Point
    {
        public int X { get; }
        public int Y { get; }

        public Point(int x, int y) => (X, Y) = (x, y);

        public void method()
        {
            //Object
            var p1 = new Point(0, 0);
            var p2 = new Point(1, 0);
        }
    }

    internal class Classes_and_Objects
    {
        
    }
}
