using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training_Day4.Collections
{
    class Queues
    {
        static void Main(string[] args)
        {
            Queue queue = new Queue();

            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(3);
            queue.Enqueue(4);
            queue.Enqueue(5);
            queue.Enqueue(6);

            queue.Dequeue();
            queue.Dequeue();

            foreach (var item in queue)
            {
                Console.WriteLine(item);
            }

            Console.ReadLine();

        }
    }
}
