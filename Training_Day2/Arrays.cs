using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training_Day2
{
    class Arrays
    {
        static void Main(string[] args)
        {
            //Single Dimensional Array
            int[] intArr = new int[3];
            intArr[0] = 100;
            intArr[1] = 200;
            intArr[2] = 300;


            string[] strArr = { "C#", "Java", "Python" };

            for (int i = 0; i < intArr.Length; i++)
            {
                Console.WriteLine("Value at index {0} is {1}", i, intArr[i]);
            }

            foreach (string str in strArr)
            {
                Console.WriteLine("Values are {0}", str);
            }


            //Two Dimensional Array
            int[,] marks = new int[2, 3];
            marks[0, 0] = 65; 
            marks[0, 1] = 75;
            marks[0, 2] = 69;

            marks[1, 0] = 90;
            marks[1, 1] = 80;
            marks[1, 2] = 70;

            for (int i = 0; i < marks.GetLength(0); i++)
            {
                for (int j = 0; j < marks.GetLength(1); j++)
                {
                    Console.WriteLine("Values are {0}", marks[i, j]);
                }
            }
            Console.ReadLine();
        }
    }
}
