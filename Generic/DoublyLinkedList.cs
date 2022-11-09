using System;
using System.Collections.Generic;
using System.Text;

namespace Generic
{
    internal class DoublyLinkedList : LinkedList
    {
        public LinkedListNode tempNode { get; set; }
        public override void AddToLinkedList(object _value)
        {
            LinkedListNode node = new LinkedListNode();            
            node.Value = _value;

            if (First == null)
            {
                First = node;
                Last = node;
            }
            else
            {
                Last.Next = node;
                tempNode = Last;
                Last = node;
                Last.Prev = tempNode;                
            }
        }

        internal override void DisplayPrevLinkedListItem(object value)
        {
            LinkedListNode current = Last;
            while (current != null)
            {
                Console.WriteLine(current.Value);
                current = current.Prev;
            }
        }
    }
}
