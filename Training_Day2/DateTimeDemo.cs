using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training_Day2
{
    class DateTimeDemo
    {
        static void Main(string[] args)
        {
            DateTime date1 = new DateTime(2019, 02, 13);
            Console.WriteLine(date1);

            DateTime date2 = DateTime.Now;
            Console.WriteLine(date2);

            DateTime date3 = DateTime.Now.AddYears(3);
            Console.WriteLine(date3);

            DateTime date4 = DateTime.UtcNow;
            Console.WriteLine(date4);

            Console.WriteLine(date1.Date);
            Console.WriteLine(date1.Day);
            Console.WriteLine(date1.Year);
            Console.WriteLine(date1.Month);

            string strDate = "2018/11/16";
            DateTime date5 = DateTime.Parse(strDate);
            Console.WriteLine(date5);

            DateTime d1 = new DateTime(2019, 01, 01);
            DateTime d2 = new DateTime(2019, 03, 05);
            TimeSpan t = d2 - d1;
            Console.WriteLine("\n" + t);
            Console.ReadLine();
        }
    }
}
