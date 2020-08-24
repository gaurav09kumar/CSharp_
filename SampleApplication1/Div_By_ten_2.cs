using System;
using System.Text;

namespace SampleApplication1
{
    class Div_By_ten_2
    {
        public void Divisble_By()
        {
            Console.WriteLine("Enter starting number: ");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter ending number: ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            for (int i =num1; i<= num2; i++)
            {
                if (i % 10 == 0)
                {
                    Console.WriteLine($"The number {i} is divisble by 10");
                }
            }
        }

    }
}