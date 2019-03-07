using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3
{
    class Person
    {

         public string FName; //field

         string LName;//field


        private int _salary=1000;

        public int MyProperty { get;  } // prop definition

        public int Salary       //property= get+set// propfull definition
        {
            get {
                _salary = calculateSalary();
                return _salary;

            }
            //set { _salary = value; }
        }

        //private int myVar;

        //public int MyProperty
        //{
        //    get { return myVar; }
        //    set { myVar = value; }
        //}


        private int calculateSalary()
        {
            return 3000;
        }
    }


    class properties
    {
        static void Main(string[] args)
        {
            Person per = new Person();
            Console.WriteLine(per.FName);// field
            per.FName = "Sachin";

            Console.WriteLine(per.Salary);//property
           // per.Salary = 8900;

            Console.ReadLine();
        }

    }
}
