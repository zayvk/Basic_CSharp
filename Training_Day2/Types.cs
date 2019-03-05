using System;
namespace Training_Day2
{
    class Types
    {
        static void Main(string[] args)
        {
            int i = 100;
            Console.WriteLine("Value before Pass by value: " + i);
            PassByValue(i);
            Console.WriteLine("Value after Pass by value: " + i);

            Employee emp = new Employee() { id = 121, name = "Sujit" };
            Console.WriteLine("Before Pass by Reference: " + emp.id + " and " + emp.name);
            PassByReference(emp);
            Console.WriteLine("After Pass by Reference: " + emp.id + " and " + emp.name);

            Console.WriteLine("Value before Pass by value using ref: " + i);
            PassValuetypeByReference(ref i);
            Console.WriteLine("Value after Pass by value using ref: " + i);
            Console.ReadLine();
        }

        /// <summary>
        /// Pass by value - Whenever we pass a value type then a copy of that variable is created and updation happens on the copy...
        /// </summary>
        /// <param name="num"></param>
        static void PassByValue(int num)
        {
            num = 200;
        }

        /// <summary>
        /// Pass by reference - Whenever we pass reference type then the original value gets updated...
        /// </summary>
        /// <param name="emp"></param>
        static void PassByReference(Employee emp)
        {
            emp.id = 113;
            emp.name = "Ranjit";
        }

        /// <summary>
        /// Using Ref - We can pass value types as reference types wusing the Ref keyword...
        /// </summary>
        /// <param name="num"></param>
        static void PassValuetypeByReference(ref int num)
        {
            num = 200;
        }
    }

    public class Employee
    {
        public int id;
        public string name;
    }
}
