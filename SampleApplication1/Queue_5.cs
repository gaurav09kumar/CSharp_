using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace SampleApplication1
{
    class Queue_5
    {
        public void Queue_method()
        {
            //non generic
            Queue qu_non_generic = new Queue();

            qu_non_generic.Enqueue(10);
            qu_non_generic.Enqueue("XYZ");
            qu_non_generic.Enqueue(4500f);

            qu_non_generic.Dequeue();

            Console.WriteLine("Items in the Non generic Queue are :");
            foreach (var item in qu_non_generic)
            {
                Console.WriteLine(item);
            }

            //generic
            Queue<int> qu_generic = new Queue<int>();

            qu_generic.Enqueue(25);
            qu_generic.Enqueue(Convert.ToInt32("40"));
            qu_generic.Enqueue(98);

            qu_generic.Dequeue();

            Console.WriteLine("Items in the <int> generic Queue are :");
            foreach (var item in qu_generic)
            {
                Console.WriteLine(item);
            }






        }

    }
}
