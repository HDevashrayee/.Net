using System;
using System.Collections.Generic;
using System.Text;

namespace Miscellaneous
{
    internal class Struct_Instances_vs_Class_Instances
    {

    }

    public class PersonClass
    {
        public string Name { get; set; }
        public int Age { get; set; }
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
        public PersonStruct(string name, int age)
        {
            Name = name;
            Age = age;
        }
    }
}
