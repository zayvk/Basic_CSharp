using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training_Day2.OOP
{

    class MathUtility
    {
        public static void Addition()
        {

        }

        public static void Substract()
        {

        }
    }

    class Test
    {
        public static int cnt1;
        public int cnt2;

        public Test()
        {
            cnt1++;
            cnt2++;
        }
    }

    class Static
    {
        static void Main(string[] args)
        {
            Method1();

            Test t1 = new Test();
            Test t2 = new Test();
            Test t3 = new Test();
            Test t4 = new Test();
            Console.WriteLine(Test.cnt1);
            Console.WriteLine(t4.cnt2);

            MathUtility.Addition();
            MathUtility.Substract();


            Console.ReadLine();
        }

        static void Method1()
        {

        }

        void Method2()
        {
             
        }
    }
}
