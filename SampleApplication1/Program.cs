using System;

namespace SampleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            //ReverseString_1 object1 = new ReverseString_1();
            //object1.Reverse();

            //Div_By_ten_2 object2 = new Div_By_ten_2();
            //object2.Divisble_By();

            //Palindrome_3 object_3 = new Palindrome_3();
            //object_3.Palindrome();

            Array_List_4 object_4 = new Array_List_4();
            object_4.Arr_List();

            //Hashtable_Demo object_5 = new Hashtable_Demo();
            //object_5.Hash_table();

            Queue_5 object_6 = new Queue_5();
            object_6.Queue_method();

            Stack_6 object_7 = new Stack_6();
            object_7.Stack_Method();

            Concurrent_Stack_Queue object_9 = new Concurrent_Stack_Queue();
            object_9.Concurrent_Stack();
            object_9.Concurrent_Queue();

            Console.ReadKey();
        }
    }
}
