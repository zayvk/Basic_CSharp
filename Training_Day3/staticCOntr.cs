using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3
{

    //Static contr is always called once
     //1. When u instaitate that class for the first time or
      //2.U access any static memebr of that class
    class Product
    {
        public static int prodNumber;

        public static string ManufName;

        static Product()
        {
            Console.WriteLine("Static contr is called");
        }
    }
    class staticCOntr
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Product.prodNumber);
            Product prd = new Product();
            Console.WriteLine(Product.ManufName);
            Product prd1 = new Product();
            Console.ReadLine();
        }

    }
}
