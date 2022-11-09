using System;
using System.Collections.Generic;
using System.Text;

namespace Generic
{
    /// <summary>
    /// Creating the Real World Entity of Linked List Node
    /// </summary>
    internal class LinkedListNode
    {
        public object Value { get; set; }
        public LinkedListNode Next { get; set; }
        public LinkedListNode Prev { get; set; }
    }

    internal abstract class LinkedList
    {
        public LinkedListNode First { get; set; }
        public LinkedListNode Last { get; set; }

        /// <summary>
        /// Method to Add items into the Linked List
        /// </summary>
        /// <param name="_value"></param>
        public virtual void AddToLinkedList(object _value)
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
                Last = node;
            }
        }

        /// <summary>
        /// Method to display all Next items. 
        /// We can further implement the IEnumerable interface
        /// to Yield IEnumerator Interface.
        /// </summary>
        public virtual void DisplayNextLinkedListItem(object value)
        {
            LinkedListNode current = First;
            while (current != null)
            {
                Console.WriteLine(current.Value);
                current = current.Next;
            }
        }

        /// <summary>
        /// Method to display all Prevous items. 
        /// We can further implement the IEnumerable interface
        /// to Yield IEnumerator Interface.
        /// </summary>
        internal abstract void DisplayPrevLinkedListItem(object value);
    }

    /// <summary>
    /// Creating the Linked List Class Itself. 
    /// It defines the First and Last Nodes of Linked List
    /// </summary>
    internal class SinglyLinkedList : LinkedList
    {
        internal override void DisplayPrevLinkedListItem(object value)
        {
            throw new NotImplementedException();
        }
    }



}
