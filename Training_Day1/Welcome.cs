using OtherNamespace;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training_Day1
{
    class Welcome
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the C# Session");

            string employeeName = Console.ReadLine();
            Console.WriteLine("Welcome " + employeeName);

            Employee emp = new Employee();
            Console.WriteLine("Company is " + emp.employeeCompany);
            Console.WriteLine("Experience is " + emp.exp);

            Products product = new Products();
            Console.WriteLine("Product is " + product.productName);
            Console.WriteLine("Id is " + product.productId);
            Console.Read();
        }
    }

    public class Employee
    {
        public string employeeCompany = "Persistent Systems Ltd";
        public double exp = 2.5;
    }
}
