using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3.inheritance
{
    //MEthod Overloading:

        //When methods has same name but diff no of paramerets/diff data types
    class Product
    {

        public void getProductDetails()
        {

        }

        public void getProductDetails(int ProductID)
        {

        }

        public void getProductDetails(float ProductID)
        {

        }

        public int getProductDetails(int ProductID,string Name)
        {
            return 7900;
        }

        //protected int getProductDetails(int ProductID, string Name)
        //{
        //    return 1900;
        //}


    }

    class MethodOverloading
    {
        static void Main(string[] args)
        {

            Product prd = new Product();
            //prd.getProductDetails()
        }

    }
}
