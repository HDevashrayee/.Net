using System;
using System.Collections.Generic;
using System.Text;

namespace Miscellaneous
{
    public static  class Struct_Instances_vs_Class_Instances
    {
        public static void Run()
        {
            //class
            PersonClass personClass = new PersonClass("Leo", 0);
            Console.WriteLine("Name = {0} \n Age = {1}", personClass.Name, personClass.Age);

            PersonClass personClass1 = personClass;
            personClass1.Name = "Spencer";
            personClass.Age = 2;

            // p1 values will also change because p2 is a refrencing p1 class.
            Console.WriteLine("Name = {0} \n Age = {1}", personClass.Name, personClass.Age);

            //struct
            PersonStruct personStruct = new PersonStruct("Max", 5);
            Console.WriteLine("Name = {0} \n Age = {1}", personStruct.Name, personStruct.Age);

            PersonStruct personStruct1 = personStruct;
            personStruct1.Name = "Joe";
            personStruct1.Age = 3;
            // p1 values remain unchanged because p2 is  copy.
            Console.WriteLine("Name = {0} \n Age = {1}", personStruct.Name, personStruct.Age);
        }
    }

    public class PersonClass
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public PersonClass()
        {

        }
        public PersonClass(string name, int age)
        {
            Name = name;
            Age = age;
        }
    }

    public struct PersonStruct
    {
        public string Name { get; set; }
        public int Age { get; set; }

        //Parameter less constructor not allowed in struct.
        //public PersonStruct()
        //{

        //}
        public PersonStruct(string name, int age)
        {
            Name = name;
            Age = age;
        }
    }
    
}
