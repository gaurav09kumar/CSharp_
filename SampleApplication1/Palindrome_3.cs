using System;
using System.Text;

namespace SampleApplication1
{
    class Palindrome_3
    {
        public void Palindrome()
        {
            Console.WriteLine("Enter a number");
            int number = Convert.ToInt32(Console.ReadLine());

            int r = 0;
            int sum = 0;
            int temp = number;

            while (number != 0)
            {
                r = number % 10;
                sum = sum * 10 + r;
                number = number / 10;
            }
            if(temp == sum)
            {
                Console.WriteLine($"The number {temp} is a palindrome");
            }
            else
            {
                Console.WriteLine($"The number {temp} is not a palindrome");
            }
        }
    }
}
