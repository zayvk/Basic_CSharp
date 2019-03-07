using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3
{
    //Class with private contr is not instantiated
    class Employee
    {
        private Employee()
        {
            Console.WriteLine("private contr is called");
        }

       public static void method1()
        {

        }

        public Employee(string name, string address) : this()
        {
            Console.WriteLine("public contr is called");
        }
    }
    class privateContr
    {

        static void Main(string[] args)
        {
            Employee.method1();

           // Employee emp = new Employee("abc","pune");
            Console.ReadLine();
        }

    }
}
