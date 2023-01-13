using System;
using System.Collections.Generic;
using System.Text;

namespace Types
{
    internal class BaseClass
    {
        //A class declaration may specify a base class. Follow the class name and type parameters with a colon and the name of the base class. Omitting a base class specification is the same as deriving from type object. In the following example, the base class of Point3D is Point. From the first example, the base class of Point is object:
        public class Point
        {
            public int X { get; }
            public int Y { get; }

            public Point(int x, int y) => (X, Y) = (x, y);
        }
        public class Point3D : Point
        {
            public int Z { get; set; }

            public Point3D(int x, int y, int z) : base(x, y)
            {
                Z = z;
            }
        }
    }
}
