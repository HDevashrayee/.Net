using System;
using System.Collections.Generic;
using System.Text;

namespace Generic
{
    internal class LinkedLists
    {
        /*
         A LinkedList is a linear data structure which stores element in the non-contiguous location. 
         The elements in a linked list are linked with each other using pointers. Or in other words, 
         LinkedList consists of nodes where each node contains a data field and a reference(link) to the next node in the list. 
         In C#, LinkedList is the generic type of collection which is defined in System.Collections.Generic namespace. 
         It is a doubly linked list, therefore, each node points forward to the Next node and backward to the Previous node. 
         It is a dynamic collection which grows, according to the need of your program. 
         It also provides fast inserting and removing elements.
         */

        //Create the link list.

        internal static void GetLinkedList()
        {
            string[] words = { "the", "fox", "jumps", "over", "the", "dog" }; ;
            LinkedList<string> sentence = new LinkedList<string>(words);


            // Add the word 'today' to the beginning of the linked list.
            sentence.AddFirst("A");

            // Move the first node to be the last node.
            LinkedListNode<string> mark1 = sentence.First;
            sentence.RemoveFirst();
            sentence.AddLast(mark1);

            // Change the last node to 'yesterday'.

            sentence.RemoveLast();
            sentence.AddLast("yestrday");

            // Move the last node to be the first node.
            mark1 = sentence.Last;
            sentence.RemoveLast();
            sentence.AddFirst(mark1);

            // Indicate the last occurence of 'the'.
            sentence.RemoveFirst();
            LinkedListNode<string> current = sentence.FindLast("the");

            // Add 'lazy' and 'old' after 'the' (the LinkedListNode named current).
            sentence.AddAfter(current, "old");
            sentence.AddAfter(current, "lazy");

            // Indicate 'fox' node.
            current = sentence.Find("fox");

            // Add 'quick' and 'brown' before 'fox':
            sentence.AddBefore(current, "quick");
            sentence.AddBefore(current, "brown");

            // Keep a reference to the current node, 'fox',
            // and to the previous node in the list. Indicate the 'dog' node.

            mark1 = current;
            LinkedListNode<string> mark2 = current.Previous;

            current = sentence.Find("dog");
            Console.WriteLine(sentence);
        }

        private static void Display(LinkedList<string> words, string test)
        {
            Console.WriteLine(test);
            foreach (string word in words)
            {
                Console.WriteLine(word + " ");
            }
            Console.WriteLine();
            Console.WriteLine();
        }

        private static void IndicateNode(LinkedListNode<string> node, string test)
        {
            Console.WriteLine(test);
            if (node.List == null)
            {
                Console.WriteLine("Node '{0}' is not in the list.\n", node.Value);
                return;
            }

            StringBuilder result = new StringBuilder("(" + node.Value + ")");
            
        }
    }
}
