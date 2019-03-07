using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3
{

    class A
    {
        //for const variables u need to provide value at the time of declaration itself
        //const values are by default static
        //const cab declared as global/local variable


       //readonly variables
       //u may or may not initialize value at the time of delcaring
       //readonly can be declared as global variables only

        public const float pi = 3.14f;

        public readonly int side ;

        //public const float pi;
        public A(int _side)
        {
            side = _side;
        }

        public void method1()
        {
            string name = "PSL"; //local variable are available within the method only

           const float pi1 = 3.14f;

        }
    }
      class const_readonly
    {
        static void Main(string[] args)
        {
            A a = new A(1900);
            //a.side = 8900;
            //a.
            //A.pi = 5.67f;
        }
    }
}
