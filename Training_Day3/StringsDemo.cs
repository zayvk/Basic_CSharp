using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training_Day3
{
    class StringsDemo
    {
        static void Main(string[] args)
        {
            //StringBuilder class

            //string is immutable reference type
            string list = "first";  //one ref is created in memory

            list = list + "second";//second ref

            list = list + "third"; //third ref

            Console.WriteLine(list);

            StringBuilder str2 = new StringBuilder("first");
            str2.Append("second");
            str2.Append("third");

            str2.Insert(0, "new value");
            Console.WriteLine(str2);

            Console.ReadLine();
        }
    }
}
