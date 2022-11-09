using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace Types
{
    /* 
     Interfaces may employ multiple inheritance. In the following example, the interface IComboBox inherits from both ITextBox and IListBox.

     */

    interface IControl
    {
        void Paint();
    }

    interface ITextBox : IControl
    {
        void SetText(string text);
    }

    interface IListBox : IControl
    {
        void SetItems(string[] items);
    }

    interface IComboBox : ITextBox, IListBox { }

    //Classes and structs can implement multiple interfaces. In the following example, the class EditBox implements both IControl and IDataBound.


    interface IDataBound
    {
        void Bind(Binder b);
    }

    public class EditBox : IControl, IDataBound
    {
        public void Paint() { }
        public void Bind(Binder b) { }
    }

    //When a class or struct implements a particular interface, instances of that class or struct can be implicitly converted to that interface type. For example

    public class Test
    {
        EditBox editBox = new EditBox();
        //IControl control = editBox;
        //IDataBound dataBound = editBox;
    }
}


