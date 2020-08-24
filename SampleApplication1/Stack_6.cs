using System;
using System.Collections;
using System.Collections.Generic;
using System.Net.Http.Headers;
using System.Text;

namespace SampleApplication1
{
    class Stack_6
    {
        public void Stack_Method()
        {

            //non generic
            Stack st_non_generic = new Stack();

            st_non_generic.Push(45);
            st_non_generic.Push("ABC");
            st_non_generic.Push(450000f);

            st_non_generic.Pop();

            Console.WriteLine("Items in the Non generic Stack are :");
            foreach (var item in st_non_generic)
            {
                Console.WriteLine(item);
            }

            //Generic
            Stack <int> st_generic = new Stack<int>();

            st_generic.Push(95);
            st_generic.Push(45);
            st_generic.Push(50000);

            st_generic.Pop();

            Console.WriteLine("Items in the <int> Generic Stack are :");
            foreach (var item in st_generic)
            {
                Console.WriteLine(item);
            }
        }
    }
}
