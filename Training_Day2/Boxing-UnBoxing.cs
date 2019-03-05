using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training_Day2
{
    class Boxing_UnBoxing
    {
        static void Main(string[] args)
        {
            //Boxing: converting value type to reference types
            int j = 200;
            object o = j;  //Implicitli happens

            //Unboxing: converting Reference type to value types
            object obj = 100;
            int i = (int)obj; //Explicitly need to do
        }
    }
}
