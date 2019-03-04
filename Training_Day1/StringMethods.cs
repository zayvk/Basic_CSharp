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

            //String Compare
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

            //String compare using Equals
            if (str1.Equals(str2))
            {
                Console.WriteLine("Strings are Equal using Equals()");
            }
            else
            {
                Console.WriteLine("Strings are not Equal using Equals()");
            }

            //Convert to string
            int price = 50;
            string strprice = price.ToString();

            //Padding
            string language = "Python";
            language = language.PadLeft(10, '#');
            Console.WriteLine(language);

            //Splitting string
            string langNames = "Java|C#|Typescript|F#|JQuery|C|C++";
            string[] names = langNames.Split('|');
            foreach (string lan in names)
            {
                Console.WriteLine(lan);
            }

            //Joining Strings
            string n1 = "Hello, ";
            string n2 = "Welcome to ";
            string n3 = "string tutorial";

            string join = string.Join("", n1, n2, n3);
            Console.WriteLine(join);

            Console.Read();
        }
    }
}
