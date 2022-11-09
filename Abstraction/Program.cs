using System;

namespace Abstraction
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Abstraction!");
        }
    }
    #region Example1

    abstract class Shape
    {
        protected abstract int GetArea();
    }

    class Square:Shape
    {
        private int area;

        public Square(int area)
        {
            this.area = area;
        }

        protected override int GetArea()
        {
            return area * area;
        }
    }
    #endregion

    #region Example2
    abstract class BaseClass
    {
        protected int _x = 100;
        protected int _y = 150;

        // Abstract Method
        protected abstract void AbstractMethod();

        // Abstract properties
        protected abstract int x { get; }
        protected abstract int y { get; }
    }

    class DerivedClass : BaseClass
    {
        protected override void AbstractMethod()
        {
            _x++;
            _y++;
        }

        protected override int x
        {
            get { return _x + 10; }
        }

        protected override int y
        {
            get { return _y + 10; }
        }
    }
    #endregion


}
