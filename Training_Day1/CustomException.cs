using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training_Day1
{
    class CustomException
    {
        static void Main(string[] args)
        {
            try
            {
                EvenNumberProcessing();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.ReadLine();

        }

        static void EvenNumberProcessing()
        {
            Console.WriteLine("Enter Even Number: ");
            int evenNo = Convert.ToInt32(Console.ReadLine());

            if (evenNo%2 != 0)
            {
                throw new OddNumberException("The number is Odd number.");
            }
            else
            {
                Console.WriteLine("It is an even Number.");
            }
        }
    }
}
