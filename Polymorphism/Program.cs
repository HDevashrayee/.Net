using System;
using System.Collections.Generic;

namespace Polymorphism
{
    internal class Program
    {
        /*
         Polymorphism is often referred to as the third pillar of object-oriented programming, 
        after encapsulation and inheritance. Polymorphism is a Greek word that means "many-shaped" and it has two distinct aspects:

        At run time, objects of a derived class may be treated as objects of a base class in places such as method parameters and 
        collections or arrays. When this polymorphism occurs, the object's declared type is no longer identical to its run-time type.
        Base classes may define and implement virtual methods, and derived classes can override them, which means they provide their own 
        definition and implementation. At run-time, when client code calls the method, the CLR looks up the run-time type of the object, 
        and invokes that override of the virtual method. In your source code you can call a method on a base class, and cause a derived 
        class's version of the method to be executed.
        Virtual methods enable you to work with groups of related objects in a uniform way. For example, suppose you have a drawing 
        application that enables a user to create various kinds of shapes on a drawing surface. 
        You don't know at compile time which specific types of shapes the user will create. 
        However, the application has to keep track of all the various types of shapes that are created, 
        and it has to update them in response to user mouse actions. You can use polymorphism to solve this problem in two basic steps:
        
        Create a class hierarchy in which each specific shape class derives from a common base class.
        Use a virtual method to invoke the appropriate method on any derived class through a single call to the base class method.
        First, create a base class called Shape, and derived classes such as Rectangle, Circle, and Triangle. 
        Give the Shape class a virtual method called Draw, and override it in each derived class to draw the particular shape that 
        the class represents. Create a List<Shape> object and add a Circle, Triangle, and Rectangle to it.
         */
        static void Main(string[] args)
        {
            #region Example1

            var shapes = new List<Shape>
            {
                new Rectangle(),
                new Circle()
            };

            foreach (var shape in shapes)
            {
                shape.Draw();
            }

            #endregion

            #region Example2
            BaseClass A = new BaseClass();
            A.Draw();// Output : A

            DerivedClass B = new DerivedClass();
            B.Draw();// Output : B

            BaseClass C = new DerivedClass();
            C.Draw();// Output : B
            #endregion

            #region Example3
            DerivedClass1 B1 = new DerivedClass1();
            B1.DoWork();

            BaseClass1 A1 = (BaseClass1)B1;
            A1.DoWork();
            #endregion
        }
    }

    #region Example1

    public class Shape
    {
        // Virtual method

        public virtual void Draw()
        {
            Console.WriteLine("Shape class");
        }
    }
    public class Circle : Shape
    {

        public override void Draw()
        {
            Console.WriteLine("Circle class");
            base.Draw();
        }
    }
    public class Rectangle:Shape
    {
        public override void Draw()
        {
            Console.WriteLine("Rectangle class");
            base.Draw();
        }
    }

    #endregion

    #region Example2
    public class BaseClass
    {
        public virtual void Draw() { Console.WriteLine("A"); }
        public virtual int DrawProperty
        {
            get { return 0; }
        }
    }

    public class DerivedClass : BaseClass
    {
        public override void Draw() { Console.WriteLine("B"); }
        public override int DrawProperty => base.DrawProperty;
    }
    #endregion

    #region Example3
    //Hide base class members with new members.
    public class BaseClass1
    {
        public void DoWork() { Console.WriteLine("A"); }
        public int DrawProperty;
    }

    public class DerivedClass1:BaseClass1
    {
        public new void DoWork() { Console.WriteLine("B"); }
        public new int DrawProperty;
    }

    #endregion
}
