using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training_Day4.Collections
{
    class Lists
    {
        class Employee
        {
            public int empId { get; set; }
            public string empName { get; set; }
        }

        static void Main(string[] args)
        {
            Employee emp1 = new Employee() { empId = 1, empName = "Deepak" };
            Employee emp2 = new Employee() { empId = 2, empName = "Suresh" };

            List<Employee> empList = new List<Employee>();
            empList.Add(emp1);
            empList.Add(emp2);

            foreach (Employee item in empList)
            {
                Console.WriteLine(item.empId + " " + item.empName);
            }

            Console.ReadLine();
        }
    }
}
