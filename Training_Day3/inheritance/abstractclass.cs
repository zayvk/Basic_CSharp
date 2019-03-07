using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3.inheritance
{
    //Abstract class: It can not be instantiated
    //abstract class will have abstract as well as non abstract members
    abstract class Animal
    {
        abstract public void run();

        abstract public void eat();

        public void method1()
        {

        }
    }

    //class Dog : Animal
    //{

    //}
    
    class abstractclass
    {
        static void Main(string[] args)
        {
            //Animal anm = new Animal();
        }

    }
}
