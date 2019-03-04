using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training_Day1
{
    class ExceptionHandling
    {
        static void Main(string[] args)
        {
            try
            {
                int number1, number2, result;
                Console.WriteLine("Enter number 1: ");
                number1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter number 2: ");
                number2 = Convert.ToInt32(Console.ReadLine());

                result = number1 / number2;
                Console.WriteLine("Result is " + result);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("Finally Executed");
            }
        
            Console.Read();            
        }
    }
}
