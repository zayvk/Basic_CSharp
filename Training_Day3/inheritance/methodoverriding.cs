using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3.inheritance
{

    class ConsultantEmp
    {

       public string FName ="Sachin";
       public string LNAme="T";

        public override string ToString()
        {
            return FName + " " + LNAme;
        }

        public override bool Equals(object obj)
        {
            ConsultantEmp emp = obj as ConsultantEmp;
            if (this.FName == emp.FName)
            {
                return true;
            }

            else

                return false;
            //return base.Equals(obj);
        }

        //override 
    }
    class Vehicle
    {

        public int getFuelDetails()
        {
            return 700;
        }

        //virtual keyword specifies that child class can override parent's method
        public virtual void getEngineDetails()
        {

        }
    }

    class Car : Vehicle
    {
        //Shadowing
        public new int getFuelDetails()
        {
            return 1000;
        }


        public override void getEngineDetails()
        {
            //base.getEngineDetails();
        }
    }
    
    class methodoverriding
    {
        static void Main(string[] args)
        {

            //string str1 = "hello world";
            //string str2 = "hello world";


            //Console.WriteLine(str1.Equals(str2));


            ConsultantEmp emp1=new ConsultantEmp() { FName="XYZ",LNAme="XYZ"};

            ConsultantEmp emp2 = new ConsultantEmp() { FName = "ABC", LNAme = "PQR" };

           // emp1 = emp2;
                Console.WriteLine(emp1.Equals(emp2));

            Console.ReadLine();

            int i =1900;

            //i.ToString()

            ConsultantEmp emp = new ConsultantEmp();
            Console.WriteLine(emp.ToString());


            Car car = new Car();
          Console.WriteLine("Fuel capcity is "+ car.getFuelDetails());

            Console.ReadLine();
        }
       
    }
}
