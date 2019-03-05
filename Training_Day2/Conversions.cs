using System;

namespace Training_Day2
{
    class Conversions
    {
        static void Main(string[] args)
        {
            //Implicit Conversion
            int i = 100;
            float f1 = i;

            //Explicit Conversion
            float f2 = 121.13f;
            int j = (int)f2;

            Console.WriteLine(f1);
            Console.WriteLine(j);
            Console.ReadLine();
        }
    }
}
