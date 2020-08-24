using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Text;

namespace SampleApplication1
{
    class Concurrent_Stack_Queue
    {
        /* These collections are called concurrent collections 
           because they can be accessed by multiple threads at a time. */
        public void Concurrent_Stack()
        {
            ConcurrentStack<int> con_stack = new ConcurrentStack<int>();

            con_stack.Push(25);
            con_stack.Push(150);
            con_stack.Push(Convert.ToInt32("78"));

            Console.WriteLine("Values in the concurrent Stack are :");
            foreach (var items in con_stack)
            {
                Console.WriteLine(items);
            }

        }

        public void Concurrent_Queue()
        {
            ConcurrentQueue<int> con_queue = new ConcurrentQueue<int>();

            con_queue.Enqueue(25);
            con_queue.Enqueue(150);
            con_queue.Enqueue(Convert.ToInt32("78"));

            Console.WriteLine("Values in the concurrent Queue are :");
            foreach (var items in con_queue)
            {
                Console.WriteLine(items);
            }
        }
    }
}
