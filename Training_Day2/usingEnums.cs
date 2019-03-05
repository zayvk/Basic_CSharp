using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training_Day2
{
    enum Status
    {
        Permanent,
        Temporary,
        Consultant,
        Trainee
    }

    enum Gender
    {
        Male,
        Female
    }
    class Person
    {
        public string name;
        public Status status;
        public Gender gender;
    }

    class UsingEnums
    {
        static void Main(string[] args)
        {
            Person person = new Person();
            person.name = "Jay";
            person.status = 0;
            person.gender = 0;

            Console.WriteLine("employee name is " + person.name + " with status " + person.status + " and gender is " + person.gender);
            Console.ReadLine();
        }
    }
}
