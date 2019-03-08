using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training_Day5.FileIO
{
    class FileReading
    {
        class Employee
        {
            public int id { get; set; }
            public string fname { get; set; }
            public string lname { get; set; }
        }

        static void Main(string[] args)
        {
            string path = @"C:\C# Project Training\Basic-CSharp\FilePath\Employee.txt";
            List<Employee> emplist = new List<Employee>();
            using (FileStream stream = new FileStream(path, FileMode.OpenOrCreate))
            {
                using (StreamReader reader = new StreamReader(stream))
                {
                    while (!reader.EndOfStream)
                    {
                        string line = reader.ReadLine();
                        Employee emp = new Employee();
                        string[] arrstr = line.Split(',');
                        emp.id = Convert.ToInt32(arrstr[0]);
                        emp.fname = arrstr[1].ToString();
                        emp.lname = arrstr[2].ToString();
                        emplist.Add(emp);
                        Console.WriteLine(line);
                    }
                }
            }

            foreach (Employee employee in emplist)
            {
                Console.WriteLine(employee.id + " " + employee.fname + " " + employee.lname);
            }

            Console.ReadLine();
        }
    }
}
