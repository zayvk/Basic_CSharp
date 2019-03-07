using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training_Day4
{
    class Operators
    {
        class Calculator
        {
            public int number1 { get; set; }
            public int number2 { get; set; }
            public Calculator()
            {

            }
            public Calculator(int n1, int n2)
            {
                this.number1 = n1;
                this.number2 = n2;
            }

            public static Calculator operator +(Calculator cal)
            {
                Calculator objcal = new Calculator();
                objcal.number1 = cal.number1;
                objcal.number2 = cal.number2;

                return objcal;
            }

            public static Calculator operator +(Calculator cal1, Calculator cal2)
            {
                Calculator objcal = new Calculator();
                objcal.number1 = cal1.number1 + cal1.number2;
                objcal.number2 = cal2.number1 + cal2.number2;

                return objcal;
            }

        }

        static void Main(string[] args)
        {
            int i = 100;
            i = +i;

            Calculator cal1 = new Calculator(10, 20);
            Calculator cal2 = new Calculator(111, 222);

            cal1 = +cal1;
            cal2 = +cal1;
                 
            Console.WriteLine(cal1.number1 + " " + cal1.number2);
            Console.WriteLine(cal2.number1 + " " + cal2.number2);


            Console.ReadLine();
        }
    }
}
