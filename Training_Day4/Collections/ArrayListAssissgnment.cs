using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training_Day4.Collections
{
    class ArrayListAssissgnment
    {
        static void Main(string[] args)
        {
            ArrayList arrList = new ArrayList();
            string ifContinue = "Y";

            do
            {
                Console.WriteLine("Add item to the list");
                string itemValue = Console.ReadLine();
                arrList.Add(itemValue);
                Console.WriteLine("Do you want to Continue? (Y/N)");
                ifContinue = Console.ReadLine();

            } while (ifContinue.ToUpper() == "Y");

            Console.WriteLine("List of items are: ");
            foreach (string item in arrList)
            {
                Console.WriteLine(item);
            }

            Console.ReadLine();
        }
    }
}
