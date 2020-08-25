using System;
using System.Collections.Generic;
using System.Text;

namespace SampleApplication1
{
    class Car
        {
        public Car()
        {
            Console.WriteLine("This is car class");
        }
        public void VehicleType()
        {
            Console.WriteLine("Vehicle Type : Car");
        }
        }
    class BMW : Car
    {
        public BMW()
        {
            Console.WriteLine("This is BMW class");
        }
        public void Brand()
        {
            Console.WriteLine("Brand Name : BMW");
        }
        public void Speed()
        {
            Console.WriteLine("Max Speed : 300 kmph");
        }
    }
    class BMW_300D : BMW
    {
        public BMW_300D()
        {
            Console.WriteLine("This is BMW 300d car");
        }
        public void Speed()
        {
            Console.WriteLine("Max Speed : 240 kmph");
        }

    }
    class MultiLevel_Inheritance_9
    {
        public void MultiLev_Inh()
        {
            Console.WriteLine("Implementation of Multi Level Inheritance");
            BMW_300D car = new BMW_300D();
            car.VehicleType();
            car.Brand();
            car.Speed();
        }
    }
}
