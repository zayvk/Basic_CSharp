using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training_Day1
{
    class Methods
    {
        static void Main(string[] args)
        {
            Method1();
            Method2(13, 17);
            int result = Method3(12, 14);
            Console.WriteLine("Sum = {0}", result);
            Method4();
            Method5();
            Console.Read();

        }

        /// <summary>
        /// Static methods as we need to call hte methods in the same class
        /// </summary>
        static void Method1()
        {
            Console.WriteLine("Method1 is executed");
        }

        static void Method2(int num1, int num2)
        {
            Console.WriteLine("Method2 is executed with parameters : {0} and {1} ", num1, num2);
        }

        static int Method3(int v1, int v2)
        {
            int sum = v1 + v2;
            return sum;
        }

        static void Method4()
        {
            Console.WriteLine("Enter first number: ");
            int num1 = Convert.ToInt32(Console.ReadLine());

            if (num1 == 0)
            {
                return;
            }

            Console.WriteLine("Enter second number: ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(num1 * num2);
        }

        /// <summary>
        /// We can also call one method inside another method.... Called nested methods
        /// </summary>
        static void Method5()
        {
            Method1();
        }

    }
}
