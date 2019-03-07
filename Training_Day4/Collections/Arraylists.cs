using System;
using System.Collections;

namespace Training_Day4.Collections
{
    public class Employee
    {
        public int empId { get; set; }
        public string empName { get; set; }
    }

    class Arraylists
    {
        static void Main(string[] args)
        {
            ArrayList arrlist = new ArrayList();
            arrlist.Add("C#");
            arrlist.Add("Java");
            arrlist.Add("Angular");

            for (int i = 0; i < arrlist.Count; i++)
            {
                Console.WriteLine(arrlist[i]);
            }

            Employee emp1 = new Employee() { empId = 101, empName = "Saurabh" };
            Employee emp2 = new Employee() { empId = 111, empName = "Rushikesh" };

            ArrayList empList = new ArrayList();
            empList.Add(emp1);
            empList.Add(emp2);
            //empList.Add(2);
            foreach (Employee emp in empList)
            {
                if (empList.Contains(2))
                {
                    Console.WriteLine("Wrong value 2");
                }
                else
                    Console.WriteLine("Id = " + emp.empId + " Name = " + emp.empName);
            }
            Console.ReadLine();
        }
    }
}
