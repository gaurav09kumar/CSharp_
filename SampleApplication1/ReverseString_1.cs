using System;
using System.Text;

namespace SampleApplication1
{
    class ReverseString_1
    {
        public void Reverse()
        {
            Console.WriteLine("Enter a string which you want to reverse :");
            string user_input = Console.ReadLine();

            Console.WriteLine("The reverse of entered string is :");
            for (int i = (user_input.Length - 1) ; i >= 0; i --)
            {
                Console.Write(user_input[i]);
            }
            Console.WriteLine("");
        }

    }
}