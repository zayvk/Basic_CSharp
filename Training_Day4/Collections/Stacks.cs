using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training_Day4.Collections
{
    class Stacks
    {
        static void Main(string[] args)
        {
            Stack<int> st = new Stack<int>();

            st.Push(101);
            st.Push(102);
            st.Push(103);
            st.Push(104);
            st.Push(105);
            st.Push(106);

            st.Pop();
            st.Pop();

            foreach (var item in st)
            {
                Console.WriteLine(item);
            }

            Console.ReadLine();
        }
    }
}
