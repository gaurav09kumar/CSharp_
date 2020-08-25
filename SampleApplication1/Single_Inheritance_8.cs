using System;
using System.Collections.Generic;
using System.Text;

namespace SampleApplication1
{
    //Parent class
    class Person
    {
        String name;
        int age;

        public void setPersonDetails(String n, int a)
        {
            this.name = n;
            this.age = a;
        }

        public void getPersonDetails()
        {
            Console.WriteLine($"Name is :{name}");
            Console.WriteLine($"Age is :{age}");
        }
    }
    //Child class
    class Employee : Person
    {
        int id;
        float salary;

        public void setEmployeeDetails(string name, int age, int id, float salary)
        {
            setPersonDetails(name, age);
            this.id = id;
            this.salary = salary;
        }
        public void getEmployeeDetails()
        {
            getPersonDetails();
            Console.WriteLine($"Id is :{id}");
            Console.WriteLine($"Salary is :{salary}");
        }
    }
    class Single_Inheritance_8
    {
        public void Inheritance()
        {
            Employee emp1 = new Employee();
            emp1.setEmployeeDetails("ABC", 30, 101, 75000);
            Console.WriteLine("Implementation of Single Level Inheritance");
            emp1.getEmployeeDetails();
        }
        
    }
}
