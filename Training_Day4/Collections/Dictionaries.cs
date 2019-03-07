using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training_Day4.Collections
{
    class Dictionaries
    {
        static void Main(string[] args)
        {
            Dictionary<int, Employee> empdict = new Dictionary<int, Employee>();

            Employee emp1 = new Employee() { empId=13, empName="Jay" };
            Employee emp2 = new Employee() { empId = 17, empName = "Ajay" };

            empdict.Add(1, emp1);
            empdict.Add(2, emp2);

            IDictionaryEnumerator enumerator = empdict.GetEnumerator();
            while (enumerator.MoveNext())
            {
                Console.WriteLine(enumerator.Key + " " + empdict[Convert.ToInt32(enumerator.Key)].empId + " " + empdict[Convert.ToInt32(enumerator.Key)].empName);
            }

            Console.ReadLine();
        }
    }
}
