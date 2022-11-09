using System;
using System.Collections.Generic;
using System.Text;

namespace Types
{
    /*   
     Classes define types that support inheritance and polymorphism. They enable you to create sophisticated behaviors based on hierarchies of derived classes. By contrast, struct types are simpler types whose primary purpose is to store data values. Structs can't declare a base type; they implicitly derive from System.ValueType. You can't derive other struct types from a struct type. They're implicitly sealed. 
     */
    public struct Point
    {
        public double X { get; }
        public double Y { get; }

        public Point(double x, double y) => (X, Y) = (x, y);
    }
}
