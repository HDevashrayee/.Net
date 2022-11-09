using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Generic
{
    public static class QueueClass
    {
        /*Represents a first-in, first-out collection of objects.

        This class implements a queue as a circular array. Objects stored in a Queue are inserted at one end and removed from the other.
        Queues and stacks are useful when you need temporary storage for information; that is, when you might want to discard an element after retrieving its value. 
        Use Queue if you need to access the information in the same order that it is stored in the collection. 
        Use Stack if you need to access the information in reverse order. Use ConcurrentQueue<T> or ConcurrentStack<T> 
        if you need to access the collection from multiple threads concurrently.

        Three main operations can be performed on a Queue and its elements:

        Enqueue adds an element to the end of the Queue.
        
        Dequeue removes the oldest element from the start of the Queue.
        
        Peek returns the oldest element that is at the start of the Queue but does not remove it from the Queue.

        */       
        
        public static void GetQueue()
        {
            Queue<string> myQ = new Queue<string>();

            Console.WriteLine("Enqueuing\n");
            myQ.Enqueue("one");
            myQ.Enqueue("two");
            myQ.Enqueue("three");
            myQ.Enqueue("four");
            myQ.Enqueue("five");
                        
            foreach (string item in myQ)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("\nDequeuing '{0}'", myQ.Dequeue());
            Console.WriteLine("Peek at next item to dequeue: {0}", myQ.Peek());
            Console.WriteLine("Deququing '{0}'", myQ.Dequeue());

            // Create a copy of the queue, using the ToArray method and the
            // constructor that accepts an IEnumerable<T>.

            Queue<string> myQCopy = new Queue<string>(myQ.ToArray());
            Console.WriteLine("\nContents of the first copy:");
            foreach (string item in myQCopy)
            {
                Console.WriteLine(item);
            }

            // Create an array twice the size of the queue and copy the
            // elements of the queue, starting at the middle of the
            // array.

            string[] array2 = new string[myQCopy.Count * 2];
            myQ.CopyTo(array2, myQ.Count);

            Queue<string> myQCopy2 = new Queue<string>(array2);

            foreach (string item in myQCopy2)
            {
                Console.WriteLine(item);
            }
        }
    }
}
