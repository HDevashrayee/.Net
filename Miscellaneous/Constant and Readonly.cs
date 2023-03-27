using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Miscellaneous
{
    internal class Constant_and_Readonly
    {
       public void Add()
       {
            ReadOnly readOnly = new ReadOnly(10);

            Console.WriteLine("Constant + Readonly = " + Const.constNumber + readOnly.readonlNumber);
       }
    }

    public static class Const
    {
        public const int constNumber = 5;        
        const string Language = "C#";
        const string Platform = ".NET";
        const string Version = "10.0";
        //Use the const keyword to declare a constant field or a constant local. Constant fields and locals aren't variables and may not be modified. Constants can be numbers,
        //Boolean values, strings, or a null reference.Don’t create a constant to represent information that you expect to change at any time.
        const string FullProductName = $"{Platform} - Language: {Language} Version: {Version}";        
    }

    public class ReadOnly
    {
        public readonly int readonlNumber = 5;

        public ReadOnly(int num)
        {
            readonlNumber = num;
        }
    }
}
