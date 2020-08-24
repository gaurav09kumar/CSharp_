using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace SampleApplication1
{
    class Array_List_4
    {
        public void Arr_List()
        {
            ArrayList arr = new ArrayList();
            arr.Add(10);
            arr.Add("Name_data");
            arr.Add(45.6f);

            //FOR EACH LOOP
            Console.WriteLine("Items in Array List - Printed using for each loop");
            foreach (var item in arr)
            {
                Console.WriteLine(item);
            }

            //FOR LOOP
            Console.WriteLine("Items in Array List - Printed using for loop");
            for (int i = 0; i < arr.Count; i++)
            {
                Console.WriteLine(arr[i]);
            }

            //WHILE LOOP
            Console.WriteLine("Items in Array List - Printed using while loop");
            int j = 0;
            while(j < arr.Count){
                Console.WriteLine(arr[j]);
                j++;
            }

            //DO WHILE LOOP
            Console.WriteLine("Items in Array List - Printed using do while loop");
            int z = 0;
            do
            {
                Console.WriteLine(arr[z]);
                z++;
            } while (z < arr.Count);
        }
    }
}