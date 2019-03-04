using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training_Day1
{
    class StringMethods
    {
        static void Main(string[] args)
        {
            string str1 = "Hello World";
            string str2 = "hello World";

            if (str1 == str2)
            {
                Console.WriteLine("Strings are Equal");
            }
            else
            {
                Console.WriteLine("Strings are not Equal");
            }

            Console.WriteLine("String in Uppercase: " + str1.ToUpper());
            Console.WriteLine("String in Lowercase: " + str2.ToLower());

            if (str1.Equals(str2))
            {
                Console.WriteLine("Strings are Equal using Equals()");
            }
            else
            {
                Console.WriteLine("Strings are not Equal using Equals()");
            }

            Console.Read();
        }
    }
}
